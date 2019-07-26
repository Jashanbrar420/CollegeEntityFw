using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Business
{
    public class TeacherCollegeMapps
    {
        private CollegeEntities db = new CollegeEntities();

        public TeacherCollegeMapp Details(int? id)
        {
            try
            {
                TeacherCollegeMapp objMst = db.TeacherCollegeMapps.Find(id);
                return objMst;
            }
            catch (Exception ex)
            {
                TeacherCollegeMapp objMst = null;
                return objMst;
            }
            finally
            {
                db.Dispose();
            }
        }

        public List<TeacherCollegeMapp> FullDetails()
        {
            try
            {
                List<TeacherCollegeMapp> TeacherCollegeMapps = db.TeacherCollegeMapps.Include(e => e.CollegeMst).Include(e => e.TeacherMst).ToList();
                return TeacherCollegeMapps;
            }
            catch (Exception ex)
            {
                List<TeacherCollegeMapp> TeacherCollegeMapps = null;
                return TeacherCollegeMapps;
            }
            finally
            {
                db.Dispose();
            }
        }

        public String CreateMapp(TeacherCollegeMapp objMst)
        {
            try
            {
                db.TeacherCollegeMapps.Add(objMst);
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

        public String EditMapp(TeacherCollegeMapp objMst)
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

        public String DeleteMapp(int id)
        {
            try
            {
                TeacherCollegeMapp objMst = db.TeacherCollegeMapps.Find(id);
                db.TeacherCollegeMapps.Remove(objMst);
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
