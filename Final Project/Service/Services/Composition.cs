using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Service.Services
{
    public static class Composition
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

                    if (!(prop.GetValue(whole) == null))
                        SlicesList = (List<TSlice>)prop.GetValue(whole);

                    SlicesList.Add(slice);
                    prop.SetValue(whole, SlicesList);
                }
            }

            var TypeSlice = slice.GetType();
            var PropsSlice = TypeSlice.GetProperties();

            foreach (var prop1 in PropsSlice)
            {
                Type twhole = whole.GetType();
                if (prop1.PropertyType == twhole)
                {
                    foreach (var prop2 in PropsWhole)
                    {
                        if (prop2.PropertyType == typeof(List<TSlice>))
                        {
                            var WholeToRemove = prop1.GetValue(slice);
                            if (WholeToRemove != null)
                            {
                                RmvSlice(WholeToRemove, slice);
                            }
                        }
                    }
                    prop1.SetValue(slice, whole);
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

            Type TypeSlice = slice.GetType();
            PropertyInfo[] PropsSlice = TypeSlice.GetProperties();

            foreach (var prop in PropsSlice)
            {
                if (prop.PropertyType == TypeWhole)
                {
                    prop.SetValue(slice, null);
                }
            }
        }
    }
}
