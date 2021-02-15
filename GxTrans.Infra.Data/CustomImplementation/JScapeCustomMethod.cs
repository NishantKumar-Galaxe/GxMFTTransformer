using GxTrans.Domain.Models;
using GxTrans.Infra.Data.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace GxTrans.Infra.Data.CustomImplementation
{
    public static class JScapeCustomMethod
    {
        public static DataTable ReadXML(string folderPath)
        {
            List<Jscape_UserDetail> lstUserDetails = new List<Jscape_UserDetail>();
            Dictionary<string, string> dctUserDetail = new Dictionary<string, string>();
            int tagCounter = 0;
            //string folderPath = @"E:\Nishant_Backup_Mar2020\Nishant\Project\Fiserv\JscapeToSFG\POC\Users\Fiserv_CUSolutions";

            foreach (string file in Directory.EnumerateFiles(folderPath, "*.xml"))
            {
                // var updatedFile = Path.ChangeExtension(file, ".xml");
                // File.Move(file, Path.ChangeExtension(file, ".xml"));

                // XElement xelement = XElement.Load(updatedFile);

                XElement xelement = XElement.Load(file);
                IEnumerable<XElement> tags = xelement.Elements();

                foreach (var RootTag in tags)
                {
                    IEnumerable<XElement> childElements = RootTag.Elements();
                    foreach (var element in childElements)
                    {
                        if (element.Name.LocalName.ToUpper().Equals("STRING") && tagCounter == 0)
                        {
                            dctUserDetail.Add("Name", element.Value);
                        }

                        if (element.Name.LocalName.ToUpper().Equals("STRING") && tagCounter == 1)
                        {
                            dctUserDetail.Add("LoginID", element.Value);
                            tagCounter++;
                        }

                        if (element.Attributes().Count() > 0)
                        {
                            var attributeName = element.Attributes().First().Name.LocalName;

                            if (!string.IsNullOrEmpty(attributeName) && attributeName.ToUpper().Equals("PROPERTY"))
                            {
                                var PropertyName = element.Attribute(attributeName).Value;
                                var PeropertyValue = element.Value;

                                dctUserDetail.Add(PropertyName, PeropertyValue);
                            }

                        }

                        IEnumerable<XElement> lstTags = element.Descendants("void");
                        foreach (var tag in lstTags)
                        {
                            if (tag.Attributes().First().Name.LocalName.Equals("property"))
                            {
                                var attributeName = tag.Attributes().First().Name.LocalName;
                                var PropertyName = tag.Attribute(attributeName).Value;

                                if (PropertyName.ToUpper().Equals("REALPATH"))
                                {
                                    var PeropertyValue = tag.Value;
                                    dctUserDetail.Add(PropertyName, PeropertyValue);
                                }
                            }
                        }

                        if (tagCounter == 0)
                            tagCounter++;
                    }
                }

                CreateUserRecord(lstUserDetails, dctUserDetail);
                dctUserDetail.Clear();
                tagCounter = 0;
            }

            //Push the data into Excel
            return SaveDataInExcel(lstUserDetails);
        }

        public static List<Jscape_UserDetail> CreateUserRecord(List<Jscape_UserDetail> userDetails, Dictionary<string, string> dctUserDetail)
        {
            Jscape_UserDetail userInfo = new Jscape_UserDetail();

            foreach (KeyValuePair<string, string> users in dctUserDetail)
            {
                switch (users.Key)
                {
                    case "Name":
                        userInfo.Name = users.Value;
                        break;
                    case "LoginID":
                        userInfo.LoginID = users.Value;
                        break;
                    case "realPath":
                        userInfo.RealPath = users.Value;
                        break;
                    case "company":
                        userInfo.CompanyName = users.Value;
                        break;
                    case "emailAddress":
                        userInfo.Email = users.Value;
                        break;
                    case "lastLoginDate":
                        userInfo.LastLoginDate = users.Value;
                        break;
                    case "passwordDate":
                        userInfo.LastLoginDate = users.Value;
                        break;
                    case "groups":
                        userInfo.Group = users.Value;
                        break;
                    case "phone":
                        userInfo.Phone = users.Value;
                        break;

                }
            }

            userDetails.Add(userInfo);
            return userDetails;
        }

        public static DataTable SaveDataInExcel(List<Jscape_UserDetail> finalResult)
        {
            DataTable dtUserDeatils = ConvertToDataTable(finalResult);
            return dtUserDeatils;

            //dtUserDeatils.ToCSV(@"E:\Nishant_Backup_Mar2020\Nishant\Project\Fiserv\JscapeToSFG\POC\Result\Users.csv");
        }

        public static DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
            TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();

            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }
    }
}
