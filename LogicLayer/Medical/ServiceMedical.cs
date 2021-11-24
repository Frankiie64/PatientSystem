using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using DataLayer;
using DataLayer.Models;
using EmailLayer;

namespace LogicLayer.Medical
{
    public class ServiceMedical
    {
        SqlConnection _connection;
        DataLayer.DataMedical DataMedical;
        EmailSender email;

        public ServiceMedical(SqlConnection connection)
        {
            _connection = connection;
            DataMedical = new DataMedical(_connection);
        }
        public int AddUDoc(Doctors Doc)
        {
            try
            {
                string identif = (DataMedical.ValidationExist(Doc.Identification).Identification != Doc.Identification ? "" : (DataMedical.ValidationExist(Doc.Identification)).Identification.Trim());


                if (identif != Doc.Identification)
                {                    
                    if (DataMedical.AddDoc(Doc))
                    {
                        if(EnviarCorreo(Doc.Email, "titulo", "correcto"))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                    else
                    {
                        return 2;
                    }
                                     
                }                
                else
                {
                    return 2;
                }
            }
            catch (Exception ex)
            {

                return 4;
            }
        }

        public bool SavePhoto(int id, string Photo)
        {
            return DataMedical.SavePhoto(Photo, id);
        }

        private bool EnviarCorreo(string destinario,string titulo,string cuerpo)
        {
            email = new EmailSender();

            if (email.EnviarEmail(destinario, titulo, cuerpo))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool EditDoc(Doctors Doc, string Identification)
        {
            try
            {
                if (Doc.Identification == Identification)
                {
                    return DataMedical.Edit(Doc, GlobalRepositoty.Instance.id);
                }
                else if (DataMedical.ValidationExist(Doc.Identification).Identification != Doc.Identification)
                {
                    return DataMedical.Edit(Doc,GlobalRepositoty.Instance.id);
                }
                else if (DataMedical.ValidationExist(Doc.Identification).Identification.Trim() != Doc.Identification)
                {
                    return DataMedical.Edit(Doc, GlobalRepositoty.Instance.id);
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public bool DeleteDoc(int id)
        {
            return DataMedical.Delete(id);
        }
        public Doctors GetById(int id)
        {
            return DataMedical.GetId(id);
        }
        public int GetLastId()
        {
            return DataMedical.GetLastId();
        }
        public DataTable LoadTable()
        {
            return DataMedical.GetallUsers();
        }


    }
}
