using Final_Project.grilDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    [Serializable]
    class Features
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool QualifierReq { get; set; }

        private static FeaturesTableAdapter adapter = new FeaturesTableAdapter();

        private Features(int id, string name, bool req)
        {
            Id = id;
            Name = name;
            QualifierReq = req;
        }

        public void createFeature(string fname, bool req)
        {
            adapter.InsertQuery(fname, req);
        }

        public static Features GetFeatures(int id)
        {
            DataRowCollection rows = adapter.GetDataByID(id).Rows;

            if (rows.Count != 0)
            {
                String name = rows[0][1].ToString();
                bool rq = (bool)rows[0][2];
                Features f = new Features(id, name, rq);
                return f;
            }
            else return null;

        }

        public void changeName(int ID, String newName, bool newQual)
        {
            Features f = Features.GetFeatures(ID);
            f.Name = newName;
            f.QualifierReq = newQual;
            adapter.UpdateQuery(f.Name,f.QualifierReq,f.Id);
        }

        public void deleteFeature(int ID)
        {
            try
            {
                Features f = Features.GetFeatures(ID);
                if (f != null)
                {
                    adapter.DeleteQuery(f.Id);
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("לא ניתן למחוק מאפיין זה, בדוק שלא מקושר לדברים אחרים",
                    "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }









    }
}
