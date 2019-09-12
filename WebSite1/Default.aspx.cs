using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            
        }
    }
    public class PartCategory
    {
        public PartCategory() { }
        public string Id { get; set; }
        public string SeoSlug { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string ImageS { get; set; }
        public string ImageM { get; set; }
        public string ImageL { get; set; }
        public string IsoSymbol { get; set; }
        public string SeriesCatalog { get; set; }
        public string Model { get; set; }
        public string Collateral { get; set; }
        public string ConfigurationDoc { get; set; }
        public string EdsFile { get; set; }
        public string Description { get; set; }
        public string Bullets { get; set; }
        public string PreferredProduct { get; set; }
        public string RemovedProduct { get; set; }
        public string HideFromProduction { get; set; }
    }

    protected void ReadXmlUsingXMLDocument_Click(object sender, EventArgs e)
    {
        //Create the XmlDocument.  
        XmlDocument doc = new XmlDocument();
        doc.Load(Server.MapPath("XML/19461.xml"));
        //Display all the Activities alone in the XML  
        XmlNodeList elemList = doc.GetElementsByTagName("branchItem");
        int count = 0;
        PartCategory[] PartsList = new PartCategory[elemList.Count];
        foreach (XmlNode xn in elemList)
        {
            PartsList[count] = new PartCategory();
            PartsList[count].Id = xn["id"].InnerText;
            PartsList[count].SeoSlug = xn["seoslug"].InnerText;
            PartsList[count].Type = xn["type"].InnerText;
            PartsList[count].Name =  xn["name"].InnerText;
            PartsList[count].ImageS = xn["imageS"].InnerText;
            count++;
        } 
        foreach (PartCategory pc in PartsList)
        {
            doc.Load(Server.MapPath("XML/" + pc.Id + ".xml"));
            XmlNodeList subElemList = doc.GetElementsByTagName("branchCategory");
            pc.SeoSlug = subElemList[0]["seoslug"].InnerText;
        }
    }
}