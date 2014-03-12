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

        public void runInt8Count(ref List<sbyte> nValue, string nNames, string nName, int nCount)
        {
            if (nValue.Count > nCount)
            {
                LogService logService = __singleton<LogService>.instance();
                logService.logError(TAG, string.Format("runInt8Count[{0}]", nValue.Count));
                return;
            }
            for (int i = 0; i < nValue.Count; ++i)
            {
                sbyte temp = nValue[i];
                this.runInt8(ref temp, nName + i);
            }
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

        public void runInt8Semi(ref List<sbyte> nValue, string nName)
        {
            string value_ = null;
            foreach (sbyte i in nValue) {
                if (null != value_){
                    value_ += ";";
                }
                value_ += Convert.ToString(i);
            }
            XmlNode xmlAttribute_ = mXmlDocument.CreateNode(XmlNodeType.Attribute, nName, null);
            xmlAttribute_.Value = value_;
            mXmlElement.Attributes.SetNamedItem(xmlAttribute_);
        }

        public void runInt16(ref short nValue, string nName, short nOptimal = default(short))
        {
            if (nValue == nOptimal) return;
            XmlNode xmlAttribute_ = mXmlDocument.CreateNode(XmlNodeType.Attribute, nName, null);
            xmlAttribute_.Value = Convert.ToString(nValue);
            mXmlElement.Attributes.SetNamedItem(xmlAttribute_);
        }

        public void runInt16Count(ref List<short> nValue, string nNames, string nName, int nCount)
        {
            if (nValue.Count > nCount)
            {
                LogService logService = __singleton<LogService>.instance();
                logService.logError(TAG, string.Format("runInt16Count[{0}]", nValue.Count));
                return;
            }
            for (int i = 0; i < nValue.Count; ++i)
            {
                short temp = nValue[i];
                this.runInt16(ref temp, nName + i);
            }
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

        public void runInt16Semi(ref List<short> nValue, string nName)
        {
            string value_ = null;
            foreach (short i in nValue) {
                if (null != value_) {
                    value_ += ";";
                }
                value_ += Convert.ToString(i);
            }
            XmlNode xmlAttribute_ = mXmlDocument.CreateNode(XmlNodeType.Attribute, nName, null);
            xmlAttribute_.Value = value_;
            mXmlElement.Attributes.SetNamedItem(xmlAttribute_);
        }

        public void runInt32(ref int nValue, string nName, int nOptimal = default(int))
        {
            if (nValue == nOptimal) return;
            XmlNode xmlAttribute_ = mXmlDocument.CreateNode(XmlNodeType.Attribute, nName, null);
            xmlAttribute_.Value = Convert.ToString(nValue);
            mXmlElement.Attributes.SetNamedItem(xmlAttribute_);
        }

        public void runInt32Count(ref List<int> nValue, string nNames, string nName, int nCount)
        {
            if (nValue.Count > nCount)
            {
                LogService logService = __singleton<LogService>.instance();
                logService.logError(TAG, string.Format("runInt32Count[{0}]", nValue.Count));
                return;
            }
            for (int i = 0; i < nValue.Count; ++i)
            {
                int temp = nValue[i];
                this.runInt32(ref temp, nName + i);
            }
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

        public void runInt32Semi(ref List<int> nValue, string nName) 
        {
            string value_ = null;
            foreach (int i in nValue) {
                if (null != value_) {
                    value_ += ";";
                }
                value_ += Convert.ToString(i);
            }
            XmlNode xmlAttribute_ = mXmlDocument.CreateNode(XmlNodeType.Attribute, nName, null);
            xmlAttribute_.Value = value_;
            mXmlElement.Attributes.SetNamedItem(xmlAttribute_);
        }


        public void runCrc32(ref int nValue, string nName, int nOptimal = default(int))
        {
            LogService logService = __singleton<LogService>.instance();
            logService.logError(TAG, string.Format("runCrc32[{0}]", nName));
        }

        public void runCrc32Count(ref List<int> nValue, string nNames, string nName, int nCount)
        {
            LogService logService = __singleton<LogService>.instance();
            logService.logError(TAG, string.Format("runCrc32Count[{0}]", nName));
        }

        public void runCrc32s(ref List<int> nValue, string nNames, string nName)
        {
            LogService logService = __singleton<LogService>.instance();
            logService.logError(TAG, string.Format("runCrc32s[{0}]", nName));
        }

        public void runCrc32Semi(ref List<int> nValue, string nName)
        {
            LogService logService = __singleton<LogService>.instance();
            logService.logError(TAG, string.Format("runCrc32Semi[{0}]", nName));
        }

        public void runInt64(ref long nValue, string nName, long nOptimal = default(long))
        {
            if (nValue == nOptimal) return;
            XmlNode xmlAttribute_ = mXmlDocument.CreateNode(XmlNodeType.Attribute, nName, null);
            xmlAttribute_.Value = Convert.ToString(nValue);
            mXmlElement.Attributes.SetNamedItem(xmlAttribute_);
        }

        public void runInt64Count(ref List<long> nValue, string nNames, string nName, int nCount)
        {
            if (nValue.Count > nCount)
            {
                LogService logService = __singleton<LogService>.instance();
                logService.logError(TAG, string.Format("runInt64Count[{0}]", nValue.Count));
                return;
            }
            for (int i = 0; i < nValue.Count; ++i)
            {
                long temp = nValue[i];
                this.runInt64(ref temp, nName + i);
            }
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

        public void runInt64Semi(ref List<long> nValue, string nName)
        {
            string value_ = null;
            foreach (long i in nValue) {
                if (null != value_) {
                    value_ += ";";
                }
                value_ += Convert.ToString(i);
            }
            XmlNode xmlAttribute_ = mXmlDocument.CreateNode(XmlNodeType.Attribute, nName, null);
            xmlAttribute_.Value = value_;
            mXmlElement.Attributes.SetNamedItem(xmlAttribute_);
        }

        public void runString(ref string nValue, string nName, string nOptimal = default(string)) {
            if (nValue == nOptimal) return;
            XmlNode xmlAttribute_ = mXmlDocument.CreateNode(XmlNodeType.Attribute, nName, null);
            xmlAttribute_.Value = Convert.ToString(nValue);
            mXmlElement.Attributes.SetNamedItem(xmlAttribute_);
        }

        public void runStringCount(ref List<string> nValue, string nNames, string nName, int nCount)
        {
            if (nValue.Count > nCount)
            {
                LogService logService = __singleton<LogService>.instance();
                logService.logError(TAG, string.Format("runStringCount[{0}]", nValue.Count));
                return;
            }
            for (int i = 0; i < nValue.Count; ++i)
            {
                string temp = nValue[i];
                this.runString(ref temp, nName + i);
            }
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

        public void runStringSemi(ref List<string> nValue, string nName)
        {
            string value_ = null;
            foreach (string i in nValue) {
                if (null != value_) {
                    value_ += ";";
                }
                value_ += i;
            }
            XmlNode xmlAttribute_ = mXmlDocument.CreateNode(XmlNodeType.Attribute, nName, null);
            xmlAttribute_.Value = value_;
            mXmlElement.Attributes.SetNamedItem(xmlAttribute_);
        }

        public void runFloat(ref float nValue, string nName, float nOptimal = default(float))
        {
            if (nValue == nOptimal) return;
            XmlNode xmlAttribute_ = mXmlDocument.CreateNode(XmlNodeType.Attribute, nName, null);
            xmlAttribute_.Value = Convert.ToString(nValue);
            mXmlElement.Attributes.SetNamedItem(xmlAttribute_);
        }

        public void runFloatCount(ref List<float> nValue, string nNames, string nName, int nCount)
        {
            if (nValue.Count > nCount)
            {
                LogService logService = __singleton<LogService>.instance();
                logService.logError(TAG, string.Format("runFloatCount[{0}]", nValue.Count));
                return;
            }
            for (int i = 0; i < nValue.Count; ++i)
            {
                float temp = nValue[i];
                this.runFloat(ref temp, nName + i);
            }
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

        public void runFloatSemi(ref List<float> nValue, string nName)
        {
            string value_ = null;
            foreach (float i in nValue) {
                if (null != value_) {
                    value_ += ";";
                }
                value_ += Convert.ToSingle(i);
            }
            XmlNode xmlAttribute_ = mXmlDocument.CreateNode(XmlNodeType.Attribute, nName, null);
            xmlAttribute_.Value = value_;
            mXmlElement.Attributes.SetNamedItem(xmlAttribute_);
        }

        public void runDouble(ref double nValue, string nName, double nOptimal = default(double))
        {
            if (nValue == nOptimal) return;
            XmlNode xmlAttribute_ = mXmlDocument.CreateNode(XmlNodeType.Attribute, nName, null);
            xmlAttribute_.Value = Convert.ToString(nValue);
            mXmlElement.Attributes.SetNamedItem(xmlAttribute_);
        }

        public void runDoubleCount(ref List<double> nValue, string nNames, string nName, int nCount)
        {
            if (nValue.Count > nCount)
            {
                LogService logService = __singleton<LogService>.instance();
                logService.logError(TAG, string.Format("runDoubleCount[{0}]", nValue.Count));
                return;
            }
            for (int i = 0; i < nValue.Count; ++i)
            {
                double temp = nValue[i];
                this.runDouble(ref temp, nName + i);
            }
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

        public void runDoubleSemi(ref List<double> nValue, string nName)
        {
            string value_ = null;
            foreach (double i in nValue) {
                if (null != value_) {
                    value_ += ";";
                }
                value_ += Convert.ToDouble(i);
            }
            XmlNode xmlAttribute_ = mXmlDocument.CreateNode(XmlNodeType.Attribute, nName, null);
            xmlAttribute_.Value = value_;
            mXmlElement.Attributes.SetNamedItem(xmlAttribute_);
        }

        public void runDateTime(ref DateTime nValue, string nName, DateTime nOptimal = default(DateTime))
        {
            if (nValue == nOptimal) return;
            XmlNode xmlAttribute_ = mXmlDocument.CreateNode(XmlNodeType.Attribute, nName, null);
            xmlAttribute_.Value = Convert.ToString(nValue);
            mXmlElement.Attributes.SetNamedItem(xmlAttribute_);
        }

        public void runStream<T>(ref T nValue, string nName, int nCount = 0, T nOptimal = default(T)) where T : IStream
        {
            if (null == nValue) return;
            mXmlElements.Push(mXmlElement);
            XmlElement xmlElement_ = mXmlDocument.CreateElement(nName);
            mXmlElement.AppendChild(xmlElement_);
            mXmlElement = xmlElement_;
            nValue.serialize(this, nCount);
            mXmlElement = mXmlElements.Pop();
        }

        public void runStreamCount<T>(ref List<T> nValue, string nNames, string nName, int nCount) where T : IStream
        {
            if (null == nValue) return;
            mXmlElements.Push(mXmlElement);
            XmlElement xmlElement_ = mXmlDocument.CreateElement(nNames);
            mXmlElement.AppendChild(xmlElement_);
            mXmlElement = xmlElement_;
            for (int i = 0; i < nValue.Count; i++)
            {
                T value_ = nValue[i];
                this.runStream(ref value_, nName, nCount);
            }
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
                this.runStream(ref value_, nName, 0);
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
                this.runStream(ref value_, nName, 0);
            }
            mXmlElement = mXmlElements.Pop();
        }

        public void openUrl(string nUrl)
        {
            SettingConfig settingService_ = __singleton<SettingConfig>.instance();
            string systemPath = settingService_.systemPath();
            mPath = Path.Combine(systemPath, nUrl);
            mXmlDocument = new XmlDocument();
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
            mXmlDocument = null;
            mXmlElement = null;
            mPath = null;
        }

        public XmlWriter()
        {
            mXmlElements = new Stack<XmlElement>();
            mXmlDocument = null;
            mXmlElement = null;
            mPath = null;
        }

        static readonly string TAG = typeof(XmlWriter).Name;
        Stack<XmlElement> mXmlElements;
        XmlDocument mXmlDocument;
        XmlElement mXmlElement;
        string mPath;
    }
}
