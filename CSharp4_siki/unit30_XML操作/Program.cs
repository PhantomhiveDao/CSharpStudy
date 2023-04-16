using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace unit30_XML操作
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Skills> list = new List<Skills>();

            //用来解析xml
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("XMLFile1.xml");
            //通过路径加载
            //xmlDoc.LoadXml(File.ReadAllText("XMLFile1.xml"));


            //更改xml文件类型
            XmlNode root= xmlDoc.ChildNodes[1];//得到根节点
            XmlNodeList skillList=root.ChildNodes;
            foreach (XmlNode skill in root)
            {

                Skills skillobj = new Skills();
                //foreach (XmlNode node in skill.ChildNodes)
                //{
                //    //Console.WriteLine(node.Name+":"+  node.InnerText);
                //    if (node.Name == "id")
                //    {
                //        skillobj.ID = Int32.Parse(node.InnerText);
                //    }
                //    else if (node.Name == "name")
                //    {
                //        skillobj.Name = node.InnerText;
                //        skillobj.Language = node.Attributes[0].Value;
                //    }
                //    else
                //    {
                //        skillobj.Damage = Int32.Parse(node.InnerText);
                //    }

                //}

                XmlElement idEle = skill["id"];//获得一个xml中的元素
                skillobj.ID = Int32.Parse(idEle.InnerText);//idEle.InnerText获得元素中的内容;比feach遍历更加方便
                
                XmlElement nameEle = skill["name"];
                skillobj.Name = nameEle.InnerText;

                XmlAttributeCollection attriCol = nameEle.Attributes;
                XmlAttribute attri = attriCol["lang"];
                skillobj.Language = attri.Value;

                XmlElement damageEle = skill["damage"];
                skillobj.Damage = Int32.Parse(damageEle.InnerText);

                list.Add(skillobj);



            }

            foreach (Skills n in list)
            {
                Console.WriteLine(n.ID + "|" + n.Name + "|" + n.Language + "|" + n.Damage);
            }
            //可以用类进行管理xml的文件信息。
        }
    }
}
