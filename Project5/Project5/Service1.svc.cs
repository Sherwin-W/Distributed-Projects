using System;
using System.IO;
using System.Net;
using System.Xml.Schema;
using System.Xml;
using System.Collections.Generic;

namespace Project4
{
    public class Service1 : IService1
    {
        public List<string> SearchXmlContent(string xmlUrl, string searchKey)
        {
            try
            {
                List<string> results = new List<string>();
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(xmlUrl);

                foreach (XmlElement parkElement in xmlDoc.SelectNodes("//Park"))
                {
                    string parkName = parkElement.SelectSingleNode("Name")?.InnerText;
                    List<string> elementResults = new List<string>();

                    //search for elements that match the searchKey
                    XmlNodeList matchingElements = parkElement.SelectNodes(".//" + searchKey);
                    foreach (XmlNode element in matchingElements)
                    {
                        elementResults.Add($"{element.Name} = {element.InnerText}");
                    }

                    //search for attributes
                    foreach (XmlAttribute attribute in parkElement.Attributes)
                    {
                        if (attribute.Name == searchKey || attribute.Value == searchKey)
                        {
                            elementResults.Add($"{attribute.Name} = {attribute.Value}");
                        }
                    }

                    //join element results with commas and add them to the overall results
                    if (elementResults.Count > 0)
                    {
                        results.Add($"Park Name: {parkName}, {string.Join(", ", elementResults)}");
                    }
                }

                if (results.Count == 0)
                {
                    results.Add("No matching elements or attributes found for key: " + searchKey);
                }

                return results;
            }
            catch (Exception ex)
            {
                List<string> errorResult = new List<string>
        {
            "An error occurred: " + ex.Message
        };
                return errorResult;
            }
        }
        public string VerifyXmlWithXsd(string xmlUrl, string xsdUrl)
        {
            try
            {
                string xmlData = DownloadFile(xmlUrl);
                string xsdData = DownloadFile(xsdUrl);

                if (string.IsNullOrEmpty(xmlData) || string.IsNullOrEmpty(xsdData))
                {
                    return "Failed to download XML or XSD file.";
                }

                XmlReaderSettings settings = new XmlReaderSettings();
                settings.Schemas.Add(null, XmlReader.Create(new StringReader(xsdData)));
                settings.ValidationType = ValidationType.Schema;

                using (XmlReader reader = XmlReader.Create(new StringReader(xmlData), settings))
                {
                    while (reader.Read()) ;
                }

                return "No Error"; //if the validation is successful
            }
            catch (XmlSchemaValidationException ex)
            {
                return "Validation Error: " + ex.Message;
            }
            catch (Exception ex)
            {
                return "An error occurred: " + ex.Message;
            }
        }

        private string DownloadFile(string fileUrl)
        {
            try
            {
                WebClient webClient = new WebClient();
                return webClient.DownloadString(fileUrl);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
