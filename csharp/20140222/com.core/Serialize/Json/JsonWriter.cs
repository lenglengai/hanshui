using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace com.core
{
    public class JsonWriter : ISerialize
    {
        public void runBool(ref bool nValue, string nName, bool nOptimal = default(bool))
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteValue(nValue);
        }

        public void runInt8(ref sbyte nValue, string nName, sbyte nOptimal = default(sbyte))
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteValue(nValue);
        }

        public void runInt8Count(ref List<sbyte> nValue, string nNames, string nName, int nCount)
        {
            if (nValue.Count > nCount){
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
            mJsonTextWriter.WritePropertyName(nNames);
            mJsonTextWriter.WriteStartArray();
            foreach (sbyte i in nValue) {
                mJsonTextWriter.WriteValue(i);
            }
            mJsonTextWriter.WriteEndArray();
        }

        public void runInt8Semi(ref List<sbyte> nValue, string nName)
        {
            mJsonTextWriter.WritePropertyName(nName);
            string value_ = null;
            foreach (sbyte i in nValue) {
                if (null != value_) {
                    value_ += ";";
                }
                value_ += Convert.ToString(i);
            }
            mJsonTextWriter.WriteValue(nValue);
        }

        public void runInt16(ref short nValue, string nName, short nOptimal = default(short))
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteValue(nValue);
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
            mJsonTextWriter.WritePropertyName(nNames);
            mJsonTextWriter.WriteStartArray();
            foreach (short i in nValue)
            {
                mJsonTextWriter.WriteValue(i);
            }
            mJsonTextWriter.WriteEndArray();
        }

        public void runInt16Semi(ref List<short> nValue, string nName)
        {
            mJsonTextWriter.WritePropertyName(nName);
            string value_ = null;
            foreach (short i in nValue) {
                if (null != value_) {
                    value_ += ";";
                }
                value_ += Convert.ToString(i);
            }
            mJsonTextWriter.WriteValue(nValue);
        }

        public void runInt32(ref int nValue, string nName, int nOptimal = default(int))
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteValue(nValue);
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
            mJsonTextWriter.WritePropertyName(nNames);
            mJsonTextWriter.WriteStartArray();
            foreach (int i in nValue)
            {
                mJsonTextWriter.WriteValue(i);
            }
            mJsonTextWriter.WriteEndArray();
        }

        public void runInt32Semi(ref List<int> nValue, string nName)
        {
            mJsonTextWriter.WritePropertyName(nName);
            string value_ = null;
            foreach (int i in nValue)
            {
                if (null != value_)
                {
                    value_ += ";";
                }
                value_ += Convert.ToString(i);
            }
            mJsonTextWriter.WriteValue(nValue);
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
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteValue(nValue);
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
            mJsonTextWriter.WritePropertyName(nNames);
            mJsonTextWriter.WriteStartArray();
            foreach (long i in nValue)
            {
                mJsonTextWriter.WriteValue(i);
            }
            mJsonTextWriter.WriteEndArray();
        }

        public void runInt64Semi(ref List<long> nValue, string nName)
        {
            mJsonTextWriter.WritePropertyName(nName);
            string value_ = null;
            foreach (long i in nValue) {
                if (null != value_) {
                    value_ += ";";
                }
                value_ += Convert.ToString(i);
            }
            mJsonTextWriter.WriteValue(nValue);
        }

        public void runString(ref string nValue, string nName, string nOptimal = default(string))
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteValue(nValue);
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
            mJsonTextWriter.WritePropertyName(nNames);
            mJsonTextWriter.WriteStartArray();
            foreach (string i in nValue)
            {
                mJsonTextWriter.WriteValue(i);
            }
            mJsonTextWriter.WriteEndArray();
        }

        public void runStringSemi(ref List<string> nValue, string nName)
        {
            mJsonTextWriter.WritePropertyName(nName);
            string value_ = null;
            foreach (string i in nValue) {
                if (null != value_) {
                    value_ += ";";
                }
                value_ += Convert.ToString(i);
            }
            mJsonTextWriter.WriteValue(nValue);
        }

        public void runFloat(ref float nValue, string nName, float nOptimal = default(float))
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteValue(nValue);
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
            mJsonTextWriter.WritePropertyName(nNames);
            mJsonTextWriter.WriteStartArray();
            foreach (float i in nValue)
            {
                mJsonTextWriter.WriteValue(i);
            }
            mJsonTextWriter.WriteEndArray();
        }

        public void runFloatSemi(ref List<float> nValue, string nName)
        {
            mJsonTextWriter.WritePropertyName(nName);
            string value_ = null;
            foreach (float i in nValue) {
                if (null != value_) {
                    value_ += ";";
                }
                value_ += Convert.ToString(i);
            }
            mJsonTextWriter.WriteValue(nValue);
        }

        public void runDouble(ref double nValue, string nName, double nOptimal = default(double))
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteValue(nValue);
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
            mJsonTextWriter.WritePropertyName(nNames);
            mJsonTextWriter.WriteStartArray();
            foreach (double i in nValue)
            {
                mJsonTextWriter.WriteValue(i);
            }
            mJsonTextWriter.WriteEndArray();
        }

        public void runDoubleSemi(ref List<double> nValue, string nName)
        {
            mJsonTextWriter.WritePropertyName(nName);
            string value_ = null;
            foreach (double i in nValue) {
                if (null != value_) {
                    value_ += ";";
                }
                value_ += Convert.ToString(i);
            }
            mJsonTextWriter.WriteValue(nValue);
        }

        public void runDateTime(ref DateTime nValue, string nName, DateTime nOptimal = default(DateTime))
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteValue(nValue);
        }

        public void runStream<T>(ref T nValue, string nName, int nCount = 0, T nOptimal = default(T)) where T : IStream
        {
            if (null == nValue) return;
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteStartObject();
            nValue.serialize(this, nCount);
            mJsonTextWriter.WriteEndObject();
        }

        public void runStreamCount<T>(ref List<T> nValue, string nNames, string nName, int nCount) where T : IStream
        {
            mJsonTextWriter.WritePropertyName(nNames);
            mJsonTextWriter.WriteStartArray();
            foreach (T i in nValue)
            {
                T t_ = i;
                mJsonTextWriter.WriteStartObject();
                t_.serialize(this, nCount);
                mJsonTextWriter.WriteEndObject();
            }
            mJsonTextWriter.WriteEndArray();
        }

        public void runStreams<T>(ref List<T> nValue, string nNames, string nName) where T : IStream
        {
            mJsonTextWriter.WritePropertyName(nNames);
            mJsonTextWriter.WriteStartArray();
            foreach (T i in nValue)
            {
                T t_ = i;
                mJsonTextWriter.WriteStartObject();
                t_.serialize(this, 0);
                mJsonTextWriter.WriteEndObject();
            }
            mJsonTextWriter.WriteEndArray();
        }

        public void runIntStreams<T>(ref Dictionary<int, T> nValue, string nNames, string nName) where T : IIntStream
        {
            mJsonTextWriter.WritePropertyName(nNames);
            mJsonTextWriter.WriteStartArray();
            foreach (KeyValuePair<int, T> i in nValue)
            {
                T t_ = i.Value;
                mJsonTextWriter.WriteStartObject();
                t_.serialize(this, 0);
                mJsonTextWriter.WriteEndObject();
            }
            mJsonTextWriter.WriteEndArray();
        }

        public void openUrl(string nUrl)
        {
        }

        public void selectStream(string nStreamName)
        {
            mJsonTextWriter.WriteStartObject();
        }

        public void runClose()
        {
            mJsonTextWriter.WriteEndObject();
            mJsonTextWriter.Close();
            mStringWriter.Close();
        }

        public JsonWriter() {
            mStringBuilder = new StringBuilder();
            mStringWriter = new StringWriter(mStringBuilder);
            mJsonTextWriter = new JsonTextWriter(mStringWriter);
            mJsonTextWriter.Formatting = Formatting.Indented;
        }

        static readonly string TAG = typeof(JsonWriter).Name;
        JsonTextWriter mJsonTextWriter;
        StringBuilder mStringBuilder;
        StringWriter mStringWriter;
    }
}
