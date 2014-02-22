using System;
using System.IO;
using System.Xml;
using System.Collections.Generic;

namespace com.core
{
    public class XmlWriter : ISerialize
    {
        public void runBool(ref bool nValue, string nName, bool nOptimal = default(bool))
        {
            if (nValue == nOptimal) return;
            XmlNode xmlAttribute_ = mXmlDocument.CreateNode(XmlNodeType.Attribute, nName, null);
            if (true == nValue) 
            {
                xmlAttribute_.Value = "true";
            } 
            else
            {
                xmlAttribute_.Value = "false";
            }
            mXmlElement.Attributes.SetNamedItem(xmlAttribute_);
        }

        public void runInt8(ref sbyte nValue, string nName, sbyte nOptimal = default(sbyte))
        {
            if (nValue == nOptimal) return;
            XmlNode xmlAttribute_ = mXmlDocument.CreateNode(XmlNodeType.Attribute, nName, null);
            xmlAttribute_.Value = Convert.ToString(nValue);
            mXmlElement.Attributes.SetNamedItem(xmlAttribute_);
        }

        public void runInt8s(ref List<sbyte> nValue, string nNames, string nName)
        {
            if (null == nValue) return;
            XmlElement root_ = mXmlDocument.CreateElement(nNames);
            foreach (sbyte i in nValue) 
            {
                XmlElement child_ = mXmlDocument.CreateElement(nName);
                child_.InnerText = Convert.ToString(i);
                root_.AppendChild(child_);
            }
            mXmlElement.AppendChild(root_);
        }

        public void runInt16(ref short nValue, string nName, short nOptimal = default(short))
        {
            if (nValue == nOptimal) return;
            XmlNode xmlAttribute_ = mXmlDocument.CreateNode(XmlNodeType.Attribute, nName, null);
            xmlAttribute_.Value = Convert.ToString(nValue);
            mXmlElement.Attributes.SetNamedItem(xmlAttribute_);
        }

        public void runInt16s(ref List<short> nValue, string nNames, string nName)
        {
            if (null == nValue) return;
            XmlElement root_ = mXmlDocument.CreateElement(nNames);
            foreach (short i in nValue) 
            {
                XmlElement child_ = mXmlDocument.CreateElement(nName);
                child_.InnerText = Convert.ToString(i);
                root_.AppendChild(child_);
            }
            mXmlElement.AppendChild(root_);
        }

        public void runInt32(ref int nValue, string nName, int nOptimal = default(int))
        {
            if (nValue == nOptimal) return;
            XmlNode xmlAttribute_ = mXmlDocument.CreateNode(XmlNodeType.Attribute, nName, null);
            xmlAttribute_.Value = Convert.ToString(nValue);
            mXmlElement.Attributes.SetNamedItem(xmlAttribute_);
        }

        public void runInt32s(ref List<int> nValue, string nNames, string nName)
        {
            if (null == nValue) return;
            XmlElement root_ = mXmlDocument.CreateElement(nNames);
            foreach (int i in nValue)
            {
                XmlElement child_ = mXmlDocument.CreateElement(nName);
                child_.InnerText = Convert.ToString(i);
                root_.AppendChild(child_);
            }
            mXmlElement.AppendChild(root_);
        }

        public void runInt64(ref long nValue, string nName, long nOptimal = default(long))
        {
            if (nValue == nOptimal) return;
            XmlNode xmlAttribute_ = mXmlDocument.CreateNode(XmlNodeType.Attribute, nName, null);
            xmlAttribute_.Value = Convert.ToString(nValue);
            mXmlElement.Attributes.SetNamedItem(xmlAttribute_);
        }

        public void runInt64s(ref List<long> nValue, string nNames, string nName)
        {
            if (null == nValue) return;
            XmlElement root_ = mXmlDocument.CreateElement(nNames);
            foreach (long i in nValue) 
            {
                XmlElement child_ = mXmlDocument.CreateElement(nName);
                child_.InnerText = Convert.ToString(i);
                root_.AppendChild(child_);
            }
            mXmlElement.AppendChild(root_);
        }

        public void runString(ref string nValue, string nName, string nOptimal = default(string)) {
            if (nValue == nOptimal) return;
            XmlNode xmlAttribute_ = mXmlDocument.CreateNode(XmlNodeType.Attribute, nName, null);
            xmlAttribute_.Value = Convert.ToString(nValue);
            mXmlElement.Attributes.SetNamedItem(xmlAttribute_);
        }

        public void runStrings(ref List<string> nValue, string nNames, string nName)
        {
            if (null == nValue) return;
            XmlElement root_ = mXmlDocument.CreateElement(nNames);
            foreach (string i in nValue)
            {
                XmlElement child_ = mXmlDocument.CreateElement(nName);
                child_.InnerText = i.Trim();
                root_.AppendChild(child_);
            }
            mXmlElement.AppendChild(root_);
        }

        public void runFloat(ref float nValue, string nName, float nOptimal = default(float))
        {
            if (nValue == nOptimal) return;
            XmlNode xmlAttribute_ = mXmlDocument.CreateNode(XmlNodeType.Attribute, nName, null);
            xmlAttribute_.Value = Convert.ToString(nValue);
            mXmlElement.Attributes.SetNamedItem(xmlAttribute_);
        }

        public void runFloats(ref List<float> nValue, string nNames, string nName)
        {
            if (null == nValue) return;
            XmlElement root_ = mXmlDocument.CreateElement(nNames);
            foreach (float i in nValue)
            {
                XmlElement child_ = mXmlDocument.CreateElement(nName);
                child_.InnerText = Convert.ToString(i);
                root_.AppendChild(child_);
            }
            mXmlElement.AppendChild(root_);
        }

        public void runDouble(ref double nValue, string nName, double nOptimal = default(double))
        {
            if (nValue == nOptimal) return;
            XmlNode xmlAttribute_ = mXmlDocument.CreateNode(XmlNodeType.Attribute, nName, null);
            xmlAttribute_.Value = Convert.ToString(nValue);
            mXmlElement.Attributes.SetNamedItem(xmlAttribute_);
        }

        public void runDoubles(ref List<double> nValue, string nNames, string nName)
        {
            if (null == nValue) return;
            XmlElement root_ = mXmlDocument.CreateElement(nNames);
            foreach (double i in nValue) 
            {
                XmlElement child_ = mXmlDocument.CreateElement(nName);
                child_.InnerText = Convert.ToString(i);
                root_.AppendChild(child_);
            }
            mXmlElement.AppendChild(root_);
        }

        public void runDateTime(ref DateTime nValue, string nName, DateTime nOptimal = default(DateTime))
        {
            if (nValue == nOptimal) return;
            XmlNode xmlAttribute_ = mXmlDocument.CreateNode(XmlNodeType.Attribute, nName, null);
            xmlAttribute_.Value = Convert.ToString(nValue);
            mXmlElement.Attributes.SetNamedItem(xmlAttribute_);
        }

        public void runStream<T>(ref T nValue, string nName, T nOptimal = default(T)) where T : IStream
        {
            if (null == nValue) return;
            mXmlElements.Push(mXmlElement);
            XmlElement xmlElement_ = mXmlDocument.CreateElement(nName);
            mXmlElement.AppendChild(xmlElement_);
            mXmlElement = xmlElement_;
            nValue.serialize(this);
            mXmlElement = mXmlElements.Pop();
        }

        public void runStreams<T>(ref List<T> nValue, string nNames, string nName) where T : IStream
        {
            if (null == nValue) return;
            mXmlElements.Push(mXmlElement);
            XmlElement xmlElement_ = mXmlDocument.CreateElement(nNames);
            mXmlElement.AppendChild(xmlElement_);
            mXmlElement = xmlElement_;
            for (int i = 0; i < nValue.Count; i++)
            {
                T value_ = nValue[i];
                this.runStream(ref value_, nName);
            }
            mXmlElement = mXmlElements.Pop();
        }

        public void runIntStreams<T>(ref Dictionary<int, T> nValue, string nNames, string nName) where T : IIntStream
        {
            if (null == nValue) return;
            mXmlElements.Push(mXmlElement);
            XmlElement xmlElement_ = mXmlDocument.CreateElement(nNames);
            mXmlElement.AppendChild(xmlElement_);
            mXmlElement = xmlElement_;
            foreach (KeyValuePair<int, T> i in nValue) {
                T value_ = i.Value;
                this.runStream(ref value_, nName);
            }
            mXmlElement = mXmlElements.Pop();
        }

        public void openUrl(string nUrl)
        {
            SettingConfig settingService_ = __singleton<SettingConfig>.instance();
            string systemPath = settingService_.systemPath();
            string mPath = Path.Combine(systemPath, nUrl);
            XmlDeclaration xmlDeclaration_ = mXmlDocument.CreateXmlDeclaration("1.0", "utf-8", null);
            mXmlDocument.AppendChild(xmlDeclaration_);
        }

        public void selectStream(string nStreamName) {
            mXmlElement = mXmlDocument.CreateElement(nStreamName);
            mXmlDocument.AppendChild(mXmlElement);
        }

        public void runClose()
        {
            mXmlDocument.Save(mPath);
            mXmlElements.Clear();
            mXmlElements = null;
            mXmlDocument = null;
            mXmlElement = null;
            mPath = null;
        }

        public XmlWriter()
        {
            mXmlElements = new Stack<XmlElement>();
            mXmlDocument = new XmlDocument();
            mXmlElement = null;
            mPath = null;
        }

        Stack<XmlElement> mXmlElements;
        XmlDocument mXmlDocument;
        XmlElement mXmlElement;
        string mPath;
    }
}
