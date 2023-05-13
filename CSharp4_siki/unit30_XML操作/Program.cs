using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace unit30_XML操作
{
    internal class Program
    {
        static void Main(string[] args){
            List<Skills> list = new List<Skills>();
            //用来解析xml
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("XMLFile1.xml");
            //通过路径加载
            //xmlDoc.LoadXml(File.ReadAllText("XMLFile1.xml"));


            //更改xml文件类型
            XmlNode root= xmlDoc.ChildNodes[1];//得到根节点
            //XmlNode root= xmlDoc.FirstChild;//得到的是xml的声明

            XmlNodeList skillList =root.ChildNodes;
            foreach (XmlNode skillOld in root){
                Skills skillobj = new Skills();

                XmlElement idEle = skillOld["id"];//获得一个xml中的元素，通过索引器的形式
                skillobj.ID = Int32.Parse(idEle.InnerText);//idEle.InnerText获得元素中的内容;比feach遍历更加方便
                XmlElement nameEle = skillOld["name"];
                skillobj.Name = nameEle.InnerText;

                XmlAttributeCollection attriCol = nameEle.Attributes;//AttributeCollection:属性集合
                XmlAttribute attri = attriCol["lang"];//Attribute
                skillobj.Language = attri.Value;

                XmlElement damageEle = skillOld["damage"];
                skillobj.Damage = Int32.Parse(damageEle.InnerText);
                list.Add(skillobj);
            }

            foreach (Skills n in list)
            {
                Console.WriteLine(n.ID + "|" + n.Name + "|" + n.Language + "|" + n.Damage);
            }
            //可以用类进行管理xml的文件信息。
            ///Practice
            List<XmlPractice> newSkills = new List<XmlPractice>();
            XmlDocument xmlSkills = new XmlDocument();//Document 文档
            xmlSkills.Load("XMLFInfo.xml");
            XmlNode xmlNodeRoot = xmlSkills.ChildNodes[1];
            XmlNodeList skillsList=xmlNodeRoot.ChildNodes;

            foreach (XmlNode skill in xmlNodeRoot)
            {
                XmlPractice newSkillObj = new XmlPractice();
                XmlElement Skill = skill["Skill"];
                
                XmlAttributeCollection SkillAttributes =Skill.Attributes;
                XmlAttribute SkillID = SkillAttributes["SkillID"];
                newSkillObj.SkillID = Int32.Parse(SkillID.Value);

                XmlAttribute SkillEngName = SkillAttributes["SkillEngName"];
                newSkillObj.SkillEngName = SkillEngName.InnerText;

                XmlAttribute TriggerType = SkillAttributes["TriggerType"];
                newSkillObj.TriggerType = Int32.Parse(TriggerType.Value);

                XmlAttribute ImageFile = SkillAttributes["ImageFile"];
                newSkillObj.InageFile = ImageFile.InnerText;

                XmlAttribute AvailableRace = SkillAttributes["AvailableRace"];
                newSkillObj.AvailableRace = Int32.Parse(AvailableRace.Value);

                XmlElement Name = skill["Name"];
                newSkillObj.SkillCHName=Name.InnerText;
                newSkills.Add(newSkillObj);
            }
            foreach (XmlPractice a in newSkills) {
                Console.WriteLine(a.SkillID + a.SkillEngName + a.TriggerType + a.InageFile + a.AvailableRace + a.SkillCHName);
                Console.WriteLine("0");
            }
                
        }
    }
}
