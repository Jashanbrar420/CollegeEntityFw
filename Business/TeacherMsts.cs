using Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class TeacherMsts
    {
        private CollegeEntities db = new CollegeEntities();

        public TeacherMst Details(int? id)
        {
            try
            {
                TeacherMst TeacherMst = db.TeacherMsts.Find(id);
                return TeacherMst;
            }
            catch (Exception ex)
            {
                TeacherMst TeacherMst = null;
                return TeacherMst;
            }
            finally
            {
                db.Dispose();
            }
        }

        public List<TeacherMst> FullDetails()
        {
            try
            {
                return db.TeacherMsts.ToList();
            }
            catch (Exception ex)
            {
                List<TeacherMst> TeacherMst = null;
                return TeacherMst;
            }
            finally
            {
                db.Dispose();
            }
        }

        public String CreateTeacher(TeacherMst TeacherMst)
        {
            try
            {
                db.TeacherMsts.Add(TeacherMst);
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

        public String EditTeacher(TeacherMst TeacherMst)
        {
            try
            {
                db.Entry(TeacherMst).State = EntityState.Modified;
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

        public String DeleteTeacher(int id)
        {
            try
            {
                TeacherMst TeacherMst = db.TeacherMsts.Find(id);
                db.TeacherMsts.Remove(TeacherMst);
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
