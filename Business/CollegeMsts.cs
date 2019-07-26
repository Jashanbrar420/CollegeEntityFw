using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class CollegeMsts
    {

        private CollegeEntities db = new CollegeEntities();

        public CollegeMst Details(int? id)
        {
            try
            {
                CollegeMst CollMst = db.CollegeMsts.Find(id);
                return CollMst;
            }
            catch (Exception ex)
            {
                CollegeMst CollMst = null;
                return CollMst;
            }
            finally
            {
                db.Dispose();
            }
        }

        public List<CollegeMst> FullDetails()
        {
            try
            {
                List<CollegeMst> msts = db.CollegeMsts.Include(e => e.StateMst).ToList();
                return msts;
                
            }
            catch (Exception ex)
            {
                List<CollegeMst> msts = null;
                return msts;
            }
            finally
            {
                db.Dispose();
            }
        }

        public String CreateColl(CollegeMst objMst)
        {
            try
            {
                db.CollegeMsts.Add(objMst);
                db.SaveChanges();
                return "0";
            }
            catch (Exception ex)
            {
                return "1";
            }
            finally
            {
                db.Dispose();
            }
        }

        public String EditColl(CollegeMst objMst)
        {
            try
            {
                db.Entry(objMst).State = EntityState.Modified;
                db.SaveChanges();
                return "0";
            }
            catch (Exception ex)
            {
                return "1";
            }
            finally
            {
                db.Dispose();
            }
        }

        public String DeleteColl(int id)
        {
            try
            {
                CollegeMst CollMst = db.CollegeMsts.Find(id);
                db.CollegeMsts.Remove(CollMst);
                db.SaveChanges();
                return "0";
            }
            catch (Exception ex)
            {
                return "1";
            }
            finally
            {
                db.Dispose();
            }
        }
    }
}
