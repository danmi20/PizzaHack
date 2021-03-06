﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using DS;

namespace PL_Material
{
    public class CustIDtoNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var custID = value as int?;
            try
            {
                var firstOrDefault = DataSource.customers.FirstOrDefault(x => x.CustID == custID);
                if (firstOrDefault != null)
                    return firstOrDefault.CustName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class StoreIDtoNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var storeID = value as int?;
            try
            {
                var firstOrDefault = DataSource.stores.FirstOrDefault(x => x.StoreID == storeID);
                if (firstOrDefault != null)
                    return firstOrDefault.StoreName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class RankIDtoNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var rankID = value as int?;
            try
            {
                var firstOrDefault = DataSource.ranks.FirstOrDefault(x => x.RankID == rankID);
                if (firstOrDefault != null)
                    return firstOrDefault.RankDescription;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class RankIDtoSalaryConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var rankID = value as int?;
            try
            {
                var firstOrDefault = DataSource.ranks.FirstOrDefault(x => x.RankID == rankID);
                if (firstOrDefault != null)
                    return $"{firstOrDefault.RankSalary:n}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            return 0;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class DateTimetoDateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return 0;
            var date = (DateTime)value;
            try
            {
                return date.Date.ToString("d");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class BaseIDtoDoughConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return 0;
            var baseid = (int)value;
            try
            {
                var dough = DataSource.pizzasBase.FirstOrDefault(x => x.BaseID == baseid);
                return DataSource.doughs.FirstOrDefault(x => x.DoughID == dough.Dough).Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class BaseIDtoSizeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return 0;
            var baseid = (int)value;
            try
            {
                var pBase = DataSource.pizzasBase.FirstOrDefault(x => x.BaseID == baseid);
                return DataSource.pbSize.FirstOrDefault(x => x.PbsID == pBase.PbsID).PdsSize;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class ToppingIDtoNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return 0;
            var toppingid = (int)value;
            try
            {
                return DataSource.toppingTypes.FirstOrDefault(x => x.TopTypeID == toppingid).TopTypeName;
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
