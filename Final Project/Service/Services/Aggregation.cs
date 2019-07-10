using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public static class Aggregation
    {
        public static void AddSlice<TWhole, TSlice>(TWhole whole, TSlice slice)
        {
            var TypeWhole = whole.GetType();
            var PropsWhole = TypeWhole.GetProperties();

            foreach (var prop in PropsWhole)
            {
                if (prop.PropertyType.Equals(typeof(List<TSlice>)))
                {
                    List<TSlice> SlicesList = new List<TSlice>();
                    SlicesList = (List<TSlice>)prop.GetValue(whole);
                    SlicesList.Add(slice);
                    prop.SetValue(whole, SlicesList);
                }
            }
        }

        public static void RmvSlice<TWhole, TSlice>(TWhole whole, TSlice slice)
        {
            var TypeWhole = whole.GetType();
            var PropsWhole = TypeWhole.GetProperties();

            foreach (var prop in PropsWhole)
            {
                if (prop.PropertyType == typeof(List<TSlice>))
                {
                    List<TSlice> SlicesList = new List<TSlice>();
                    SlicesList = (List<TSlice>)prop.GetValue(whole);
                    SlicesList.Remove(slice);
                    prop.SetValue(whole, SlicesList);
                }
            }
        }
    }
}
