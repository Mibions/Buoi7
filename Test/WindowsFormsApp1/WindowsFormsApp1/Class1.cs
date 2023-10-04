using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class List_int
    {
        List<int> lst_data = new List<int>();
        public void ThemGiaTri(int giaTriMoi)
        {
            lst_data.Add(giaTriMoi);
        }

        public bool TimKiemGiaTri(int giaTriCanTim)
        {
            return lst_data.Contains(giaTriCanTim);
        }
    }
}
