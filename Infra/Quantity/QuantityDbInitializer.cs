using System;
using System.Collections.Generic;
using System.Linq;
using Abc.Core.Units;
using Abc.Data.Common;
using Abc.Data.Quantity;
using Microsoft.EntityFrameworkCore;

namespace Abc.Infra.Quantity
{

    public static class QuantityDbInitializer
    {

        public static void Initialize(QuantityDbContext db)
        {
            initialize(SystemOfUnits.Units, db);
            initialize(Area.Measure, Area.Units, db);
            initialize(Counter.Measure, Counter.Units, db);
            initialize(Current.Measure, Current.Units, db);
            initialize(Distance.Measure, Distance.Units, db);
            initialize(Luminos.Measure, Luminos.Units, db);
            initialize(ManHour.Measure, ManHour.Units, db);
            initialize(Mass.Measure, Mass.Units, db);
            initialize(Persentage.Measure, Persentage.Units, db);
            initialize(Substance.Measure, Substance.Units, db);
            initialize(Temperature.Measure, Temperature.Units, db);
            initialize(Time.Measure, Time.Units, db);
            initialize(Volume.Measure, Volume.Units, db);
        }

        private static void initialize(IEnumerable<Core.Units.Data> data, QuantityDbContext db)
        {
            foreach (var d in from d in data
                              let o = db.SystemsOfUnits.FirstOrDefaultAsync(m => m.Id == d.Id).GetAwaiter().GetResult()
                              where o is null
                              select d)
            {
                db.SystemsOfUnits.Add(
                    new SystemOfUnitsData
                    {
                        Id = d.Id,
                        Code = d.Code,
                        Name = d.Name,
                        Definition = d.Definition
                    });
            }
        }

        private static void initialize(Core.Units.Data measure, List<Core.Units.Data> units, QuantityDbContext db)
        {
            addMeasure(measure, db);
            addTerms(measure, db.MeasureTerms);
            addUnits(units, measure.Id, db);
            addTerms(units, db);
            addUnitFactors(units, SystemOfUnits.SiSystemId, db);
            db.SaveChanges();
        }

        private static void addUnitFactors(List<Core.Units.Data> units, string siSystemId, QuantityDbContext db)
        {
            foreach (var d in units)
            {
                if (Math.Abs(d.Factor) < double.Epsilon) continue;
                var o = db.UnitFactors.FirstOrDefaultAsync(
                    m => m.SystemOfUnitsId == siSystemId && m.UnitId == d.Id).GetAwaiter().GetResult();

                if (!(o is null)) continue;
                db.UnitFactors.Add(
                    new UnitFactorData()
                    {
                        SystemOfUnitsId = siSystemId,
                        UnitId = d.Id,
                        Factor = d.Factor
                    });
            }
        }

        private static void addTerms(List<Core.Units.Data> units, QuantityDbContext db)
        {
            foreach (var d in units)
                addTerms(d, db.UnitTerms);
        }

        private static void addTerms<T>(Core.Units.Data measure, DbSet<T> db) where T : CommonTermData, new()
        {
            foreach (var d in measure.Terms)
            {
                var o = db.FirstOrDefaultAsync(
                    m => m.MasterId == measure.Id && m.TermId == d.TermId).GetAwaiter().GetResult();

                if (!(o is null)) continue;
                db.Add(
                    new T
                    {
                        MasterId = measure.Id,
                        TermId = d.TermId,
                        Power = d.Power
                    });
            }
        }

        private static void addMeasure(Core.Units.Data measure, QuantityDbContext db)
        {
            var o = getItem(db.Measures, measure.Id);

            if (!(o is null)) return;
            db.Measures.Add(
                new MeasureData
                {
                    Id = measure.Id,
                    Code = measure.Code,
                    Name = measure.Name,
                    Definition = measure.Definition
                });
        }

        private static T getItem<T>(IQueryable<T> set, string id) where T : UniqueEntityData
            => set.FirstOrDefaultAsync(m => m.Id == id).GetAwaiter().GetResult();

        private static void addUnits(IEnumerable<Core.Units.Data> units, string measureId, QuantityDbContext db)
        {
            foreach (var d in from d in units
                              let o = getItem(db.Units, d.Id)
                              where o is null
                              select d)
            {
                db.Units.Add(
                    new UnitData
                    {
                        MeasureId = measureId,
                        Id = d.Id,
                        Code = d.Code,
                        Name = d.Name,
                        Definition = d.Definition
                    });
            }
        }
    }
}