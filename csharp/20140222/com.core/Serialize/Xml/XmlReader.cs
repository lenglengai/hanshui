using System;
using System.IO;
using System.Xml;
using System.Collections.Generic;

namespace com.core
{
    public class XmlReader : ISerialize
    {
        public void runBool(ref bool nValue, string nName, bool nOptimal = default(bool))
        {
            nValue = nOptimal;
            XmlAttribute xmlAttribute_ = mXmlNode.Attributes[nName];
            if (null == xmlAttribute_) return;
            string text_ = xmlAttribute_.InnerText;
            if (@"true" == text_) {
                nValue = true;
            }  else if (@"false" == text_) {
                nValue = false;
            } else {
                nValue = nOptimal;
            }
        }

        public void runInt8(ref sbyte nValue, string nName, sbyte nOptimal = default(sbyte))
        {
            nValue = nOptimal;
            XmlAttribute xmlAttribute_ = mXmlNode.Attributes[nName];
            if (null != xmlAttribute_) {
                string text_ = xmlAttribute_.InnerText;
                nValue = Convert.ToSByte(text_);
            }
        }

        public void runInt8Count(ref List<sbyte> nValue, string nNames, string nName, int nCount)
        {
            for (int i = 0; i < nCount; ++i)
            {
                sbyte temp = default(sbyte);
                this.runInt8(ref temp, nName + i);
                if (default(sbyte) != temp){
                    nValue.Add(temp);
                }
            }
        }

        public void runInt8s(ref List<sbyte> nValue, string nNames, string nName)
        {
            if (null == nValue) {
                nValue = new List<sbyte>();
            }
            XmlNode xmlNode_ = mXmlNode.SelectSingleNode(nNames);
            if (null == xmlNode_) return;
            foreach (XmlNode i in xmlNode_.ChildNodes) {
                string text_ = i.InnerText;
                sbyte value_ = Convert.ToSByte(text_);
                nValue.Add(value_);
            }
        }

        public void runInt8Semi(ref List<sbyte> nValue, string nName)
        {
            XmlAttribute xmlAttribute_ = mXmlNode.Attributes[nName];
            if (null == xmlAttribute_) return;
            try {
                string text_ = xmlAttribute_.InnerText;
                string objects = text_.Trim(new char[2] { ';', ' ' });
                string[] temp = objects.Split(';');
                foreach (string i in temp)
                {
                    nValue.Add(Convert.ToSByte(i));
                }
            } catch (FormatException) {
                LogService logService = __singleton<LogService>.instance();
                logService.logError(TAG, string.Format("runInt8Semi[{0}]", nName));
            }
        }

        public void runInt16(ref short nValue, string nName, short nOptimal = default(short))
        {
            nValue = nOptimal;
            XmlAttribute xmlAttribute_ = mXmlNode.Attributes[nName];
            if (null != xmlAttribute_) {
                string text_ = xmlAttribute_.InnerText;
                nValue = Convert.ToInt16(text_);
            }
        }

        public void runInt16Count(ref List<short> nValue, string nNames, string nName, int nCount)
        {
            for (int i = 0; i < nCount; ++i)
            {
                short temp = default(short);
                this.runInt16(ref temp, nName + i);
                if (default(short) != temp)
                {
                    nValue.Add(temp);
                }
            }
        }

        public void runInt16s(ref List<short> nValue, string nNames, string nName)
        {
            if (null == nValue) {
                nValue = new List<short>();
            }
            XmlNode xmlNode_ = mXmlNode.SelectSingleNode(nNames);
            if (null == xmlNode_) return;
            foreach (XmlNode i in xmlNode_.ChildNodes) {
                string text_ = i.InnerText;
                short value_ = Convert.ToInt16(text_);
                nValue.Add(value_);
            }
        }

        public void runInt16Semi(ref List<short> nValue, string nName)
        {
            XmlAttribute xmlAttribute_ = mXmlNode.Attributes[nName];
            if (null == xmlAttribute_) return;
            try {
                string text_ = xmlAttribute_.InnerText;
                string objects = text_.Trim(new char[2] { ';', ' ' });
                string[] temp = objects.Split(';');
                foreach (string i in temp)
                {
                    nValue.Add(Convert.ToInt16(i));
                }
            }  catch (FormatException) {
                LogService logService = __singleton<LogService>.instance();
                logService.logError(TAG, string.Format("runInt16Semi[{0}]", nName));
            }
        }

        public void runInt32(ref int nValue, string nName, int nOptimal = default(int))
        {
            nValue = nOptimal;
            XmlAttribute xmlAttribute_ = mXmlNode.Attributes[nName];
            if (null != xmlAttribute_) {
                string text_ = xmlAttribute_.InnerText;
                nValue = Convert.ToInt32(text_);
            }
        }

        public void runInt32Count(ref List<int> nValue, string nNames, string nName, int nCount)
        {
            for (int i = 0; i < nCount; ++i)
            {
                int temp = default(int);
                this.runInt32(ref temp, nName + i);
                if (default(int) != temp)
                {
                    nValue.Add(temp);
                }
            }
        }

        public void runInt32s(ref List<int> nValue, string nNames, string nName)
        {
            if (null == nValue) {
                nValue = new List<int>();
            }
            XmlNode xmlNode_ = mXmlNode.SelectSingleNode(nNames);
            if (null == xmlNode_) return;
            foreach (XmlNode i in xmlNode_.ChildNodes) {
                string text_ = i.InnerText;
                int value_ = Convert.ToInt32(text_);
                nValue.Add(value_);
            }
        }

        public void runInt32Semi(ref List<int> nValue, string nName)
        {
            XmlAttribute xmlAttribute_ = mXmlNode.Attributes[nName];
            if (null == xmlAttribute_) return;
            try {
                string text_ = xmlAttribute_.InnerText;
                string objects = text_.Trim(new char[2] { ';', ' ' });
                string[] temp = objects.Split(';');
                foreach (string i in temp)
                {
                    nValue.Add(Convert.ToInt32(i));
                }
            } catch (FormatException) {
                LogService logService = __singleton<LogService>.instance();
                logService.logError(TAG, string.Format("runInt32Semi[{0}]", nName));
            }
        }

        public void runCrc32(ref int nValue, string nName, int nOptimal = default(int))
        {
            nValue = nOptimal;
            XmlAttribute xmlAttribute_ = mXmlNode.Attributes[nName];
            if (null != xmlAttribute_)
            {
                string text_ = xmlAttribute_.InnerText;
                nValue = GenerateId.runCommon(text_);
            }
        }

        public void runCrc32Count(ref List<int> nValue, string nNames, string nName, int nCount)
        {
            for (int i = 0; i < nCount; ++i)
            {
                int temp = default(int);
                this.runInt32(ref temp, nName + i);
                if (default(int) != temp)
                {
                    nValue.Add(temp);
                }
            }
        }
        
        public void runCrc32s(ref List<int> nValue, string nNames, string nName)
        {
            if (null == nValue)
            {
                nValue = new List<int>();
            }
            XmlNode xmlNode_ = mXmlNode.SelectSingleNode(nNames);
            if (null == xmlNode_) return;
            foreach (XmlNode i in xmlNode_.ChildNodes)
            {
                string text_ = i.InnerText;
                int value_ = GenerateId.runCommon(text_);
                nValue.Add(value_);
            }
        }

        public void runCrc32Semi(ref List<int> nValue, string nName)
        {
            XmlAttribute xmlAttribute_ = mXmlNode.Attributes[nName];
            if (null == xmlAttribute_) return;
            try {
                string text_ = xmlAttribute_.InnerText;
                string objects = text_.Trim(new char[2] { ';', ' ' });
                string[] temp = objects.Split(';');
                foreach (string i in temp)
                {
                    nValue.Add(GenerateId.runCommon(i));
                }
            }  catch (FormatException) {
                LogService logService = __singleton<LogService>.instance();
                logService.logError(TAG, string.Format("runCrc32Semi[{0}]", nName));
            }
        }

        public void runInt64(ref long nValue, string nName, long nOptimal = default(long))
        {
            nValue = nOptimal;
            XmlAttribute xmlAttribute_ = mXmlNode.Attributes[nName];
            if (null != xmlAttribute_) {
                string text_ = xmlAttribute_.InnerText;
                nValue = Convert.ToInt64(text_);
            }
        }

        public void runInt64Count(ref List<long> nValue, string nNames, string nName, int nCount)
        {
            for (int i = 0; i < nCount; ++i)
            {
                long temp = default(long);
                this.runInt64(ref temp, nName + i);
                if (default(int) != temp)
                {
                    nValue.Add(temp);
                }
            }
        }

        public void runInt64s(ref List<long> nValue, string nNames, string nName)
        {
            if (null == nValue) {
                nValue = new List<long>();
            }
            XmlNode xmlNode_ = mXmlNode.SelectSingleNode(nNames);
            if (null == xmlNode_) return;
            foreach (XmlNode i in xmlNode_.ChildNodes) {
                string text_ = i.InnerText;
                long value_ = Convert.ToInt64(text_);
                nValue.Add(value_);
            }
        }

        public void runInt64Semi(ref List<long> nValue, string nName)
        {
            XmlAttribute xmlAttribute_ = mXmlNode.Attributes[nName];
            if (null == xmlAttribute_) return;
            try {
                string text_ = xmlAttribute_.InnerText;
                string objects = text_.Trim(new char[2] { ';', ' ' });
                string[] temp = objects.Split(';');
                foreach (string i in temp)
                {
                    nValue.Add(Convert.ToInt64(i));
                }
            } catch (FormatException) {
                LogService logService = __singleton<LogService>.instance();
                logService.logError(TAG, string.Format("runInt64Semi[{0}]", nName));
            }
        }

        public void runString(ref string nValue, string nName, string nOptimal = default(string))
        {
            nValue = nOptimal;
            XmlAttribute xmlAttribute_ = mXmlNode.Attributes[nName];
            if (null != xmlAttribute_) {
                nValue = xmlAttribute_.InnerText;
            }
        }

        public void runStringCount(ref List<string> nValue, string nNames, string nName, int nCount)
        {
            for (int i = 0; i < nCount; ++i)
            {
                string temp = default(string);
                this.runString(ref temp, nName + i);
                if (default(string) != temp)
                {
                    nValue.Add(temp);
                }
            }
        }

        public void runStrings(ref List<string> nValue, string nNames, string nName)
        {
            if (null == nValue) {
                nValue = new List<string>();
            }
            XmlNode xmlNode_ = mXmlNode.SelectSingleNode(nNames);
            if (null == xmlNode_) return;
            foreach (XmlNode i in xmlNode_.ChildNodes) {
                string text_ = i.InnerText;
                nValue.Add(text_);
            }
        }

        public void runStringSemi(ref List<string> nValue, string nName)
        {
            XmlAttribute xmlAttribute_ = mXmlNode.Attributes[nName];
            if (null == xmlAttribute_) return;
            try {
                string text_ = xmlAttribute_.InnerText;
                string objects = text_.Trim(new char[2] { ';', ' ' });
                string[] temp = objects.Split(';');
                foreach (string i in temp)
                {
                    nValue.Add(i);
                }
            } catch (FormatException) {
                LogService logService = __singleton<LogService>.instance();
                logService.logError(TAG, string.Format("runStringSemi[{0}]", nName));
            }
        }

        public void runFloat(ref float nValue, string nName, float nOptimal = default(float))
        {
            nValue = nOptimal;
            XmlAttribute xmlAttribute_ = mXmlNode.Attributes[nName];
            if (null != xmlAttribute_) {
                string text_ = xmlAttribute_.InnerText;
                nValue = Convert.ToSingle(text_);
            }
        }

        public void runFloatCount(ref List<float> nValue, string nNames, string nName, int nCount)
        {
            for (int i = 0; i < nCount; ++i)
            {
                float temp = default(float);
                this.runFloat(ref temp, nName + i);
                if (default(float) != temp)
                {
                    nValue.Add(temp);
                }
            }
        }

        public void runFloats(ref List<float> nValue, string nNames, string nName)
        {
            if (null == nValue) {
                nValue = new List<float>();
            }
            XmlNode xmlNode_ = mXmlNode.SelectSingleNode(nNames);
            if (null == xmlNode_) return;
            foreach (XmlNode i in xmlNode_.ChildNodes) {
                string text_ = i.InnerText;
                float value_ = Convert.ToSingle(text_);
                nValue.Add(value_);
            }
        }

        public void runFloatSemi(ref List<float> nValue, string nName)
        {
            XmlAttribute xmlAttribute_ = mXmlNode.Attributes[nName];
            if (null == xmlAttribute_) return;
            try {
                string text_ = xmlAttribute_.InnerText;
                string objects = text_.Trim(new char[2] { ';', ' ' });
                string[] temp = objects.Split(';');
                foreach (string i in temp)
                {
                    nValue.Add(Convert.ToSingle(i));
                }
            } catch (FormatException) {
                LogService logService = __singleton<LogService>.instance();
                logService.logError(TAG, string.Format("runStringSemi[{0}]", nName));
            }
        }

        public void runDouble(ref double nValue, string nName, double nOptimal = default(double))
        {
            nValue = nOptimal;
            XmlAttribute xmlAttribute_ = mXmlNode.Attributes[nName];
            if (null != xmlAttribute_) {
                string text_ = xmlAttribute_.InnerText;
                nValue = Convert.ToDouble(text_);
            }
        }

        public void runDoubleCount(ref List<double> nValue, string nNames, string nName, int nCount)
        {
            for (int i = 0; i < nCount; ++i)
            {
                double temp = default(double);
                this.runDouble(ref temp, nName + i);
                if (default(double) != temp)
                {
                    nValue.Add(temp);
                }
            }
        }

        public void runDoubles(ref List<double> nValue, string nNames, string nName)
        {
            if (null == nValue) {
                nValue = new List<double>();
            }
            XmlNode xmlNode_ = mXmlNode.SelectSingleNode(nNames);
            if (null == xmlNode_) return;
            foreach (XmlNode i in xmlNode_.ChildNodes) {
                string text_ = i.InnerText;
                double value_ = Convert.ToDouble(text_);
                nValue.Add(value_);
            }
        }

        public void runDoubleSemi(ref List<double> nValue, string nName)
        {
            XmlAttribute xmlAttribute_ = mXmlNode.Attributes[nName];
            if (null == xmlAttribute_) return;
            try {
                string text_ = xmlAttribute_.InnerText;
                string objects = text_.Trim(new char[2] { ';', ' ' });
                string[] temp = objects.Split(';');
                foreach (string i in temp)
                {
                    nValue.Add(Convert.ToDouble(i));
                }
            } catch (FormatException) {
                LogService logService = __singleton<LogService>.instance();
                logService.logError(TAG, string.Format("runDoubleSemi[{0}]", nName));
            }
        }

        public void runDateTime(ref DateTime nValue, string nName, DateTime nOptimal = default(DateTime))
        {
            nValue = nOptimal;
            XmlAttribute xmlAttribute_ = mXmlNode.Attributes[nName];
            if (null != xmlAttribute_)
            {
                string text_ = xmlAttribute_.InnerText;
                nValue = Convert.ToDateTime(text_);
            }
        }

        public void runStream<T>(ref T nValue, string nName, int nCount = 0, T nOptimal = default(T)) where T : IStream
        {
            mXmlNodes.Push(mXmlNode);
            mXmlNode = mXmlNode.SelectSingleNode(nName);
            if (null == mXmlNode) {
                nValue = nOptimal;
            } else {
                if (object.Equals(nValue, default(T)))
                {
                    nValue = Activator.CreateInstance<T>();
                }
                nValue.serialize(this, nCount);
            }
            mXmlNode = mXmlNodes.Pop();
        }

        public void runStreamCount<T>(ref List<T> nValue, string nNames, string nName, int nCount) where T : IStream
        {
            if (null == nValue)
            {
                nValue = new List<T>();
            }
            mXmlNodes.Push(mXmlNode);
            XmlNode xmlNode_ = mXmlNode.SelectSingleNode(nNames);
            if (null != xmlNode_)
            {
                foreach (XmlNode i in xmlNode_.ChildNodes)
                {
                    mXmlNode = i;
                    T t_ = Activator.CreateInstance<T>();
                    t_.serialize(this, nCount);
                    nValue.Add(t_);
                }
            }
            mXmlNode = mXmlNodes.Pop();
        }

        public void runStreams<T>(ref List<T> nValue, string nNames, string nName) where T : IStream
        {
            if (null == nValue) {
                nValue = new List<T>();
            }
            mXmlNodes.Push(mXmlNode);
            XmlNode xmlNode_ = mXmlNode.SelectSingleNode(nNames);
            if (null != xmlNode_) {
                foreach (XmlNode i in xmlNode_.ChildNodes) {
                    mXmlNode = i;
                    T t_ = Activator.CreateInstance<T>();
                    t_.serialize(this, 0);
                    nValue.Add(t_);
                }
            }
            mXmlNode = mXmlNodes.Pop();
        }

        public void runIntStreams<T>(ref Dictionary<int, T> nValue, string nNames, string nName) where T : IIntStream
        {
            if (null == nValue)
            {
                nValue = new Dictionary<int, T>();
            }
            mXmlNodes.Push(mXmlNode);
            XmlNode xmlNode_ = mXmlNode.SelectSingleNode(nNames);
            if (null != xmlNode_)
            {
                foreach (XmlNode i in xmlNode_.ChildNodes)
                {
                    mXmlNode = i;
                    T t_ = Activator.CreateInstance<T>();
                    t_.serialize(this, 0);
                    nValue[t_.getKey()] = t_;
                }
            }
            mXmlNode = mXmlNodes.Pop();
        }

        public void openUrl(string nUrl) {
            SettingConfig settingConfig_ = __singleton<SettingConfig>.instance();
            string systemPath = settingConfig_.systemPath();
            string url_ = Path.Combine(systemPath, nUrl);
            mXmlDocument.Load(url_);
        }

        public void selectStream(string nStreamName) {
            mXmlNode = mXmlDocument.SelectSingleNode(nStreamName);
        }

        public void runClose() {
            mXmlDocument = null;
            mXmlNodes.Clear();
            mXmlNodes = null;
            mXmlNode = null;
        }

        public XmlReader() {
            mXmlDocument = new XmlDocument();
            mXmlNodes = new Stack<XmlNode>();
            mXmlNode = null;
        }
        static readonly string TAG = typeof(XmlReader).Name;
        XmlDocument mXmlDocument;
        Stack<XmlNode> mXmlNodes;
        XmlNode mXmlNode;
    }
}
