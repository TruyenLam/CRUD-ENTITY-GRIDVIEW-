using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.Entity;

namespace TEST_FINGER
{
    public partial class Form2 : DevExpress.XtraEditors.XtraForm
    {
        VanTayEntities db = new VanTayEntities();
        public Form2()
        {
            InitializeComponent();
            loadMayVanTay();
        }

        public void loadMayVanTay()
        {
            db.FP_DanhMucMayQuetVanTay.Load();
            fP_DanhMucMayQuetVanTayBindingSource.DataSource = db.FP_DanhMucMayQuetVanTay.Local;
        }

        private void btnsave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            db.SaveChanges();
            XtraMessageBox.Show("Luu thành cong");
        }

        private void btncancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var changed = db.ChangeTracker.Entries().Where(x => x.State != EntityState.Unchanged).ToList();
            foreach (var obj in changed)
            {
                switch (obj.State)
                {
                    
                    case EntityState.Added:
                        obj.State = EntityState.Detached;
                        break;
                    case EntityState.Deleted:
                        obj.State = EntityState.Unchanged;
                        break;
                    case EntityState.Modified:
                        obj.CurrentValues.SetValues(obj.OriginalValues);
                        obj.State = EntityState.Unchanged;
                        break; 
                    
                }
            }
            fP_DanhMucMayQuetVanTayBindingSource.ResetBindings(false);
        }

        private void btndelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gvMayVanTay.DeleteSelectedRows();
        }
    }
}