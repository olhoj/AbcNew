using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Abc.Aids {

    public static class SystemRegionInfo {

        public static bool IsCountry(RegionInfo r) {
            return Safe.Run(() => SystemString.StartsWithLetter(r.ThreeLetterISORegionName), false);
        }

        public static List<RegionInfo> GetRegionsList() {
            return Safe.Run(() => {
                var cultures = SystemCultureInfo.GetSpecificCultures();
                var regions = SystemEnumerable.Convert(cultures, SystemCultureInfo.ToRegionInfo);
                regions = SystemEnumerable.Distinct(regions);
                var list = regions.ToList();
                removeNotCountries(list);
                regions = SystemEnumerable.OrderBy(list.ToArray(), p => p.EnglishName);
                return regions.ToList();
            }, new List<RegionInfo>());
        }

        private static void removeNotCountries(List<RegionInfo> cultures)
        {
            for(var i = cultures.Count; i > 0; i--)
            {
                var c = cultures[i - 1];
                if (c!= null && c.EnglishName != null) continue;
                cultures.RemoveAt(i - 1);
            }
        }
    }
}


