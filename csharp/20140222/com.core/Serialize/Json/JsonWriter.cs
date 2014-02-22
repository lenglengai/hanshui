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

        public void runInt8s(ref List<sbyte> nValue, string nNames, string nName)
        {
            mJsonTextWriter.WritePropertyName(nNames);
            mJsonTextWriter.WriteStartArray();
            foreach (sbyte i in nValue) {
                mJsonTextWriter.WriteValue(i);
            }
            mJsonTextWriter.WriteEndArray();
        }

        public void runInt16(ref short nValue, string nName, short nOptimal = default(short))
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteValue(nValue);
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

        public void runInt32(ref int nValue, string nName, int nOptimal = default(int))
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteValue(nValue);
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

        public void runInt64(ref long nValue, string nName, long nOptimal = default(long))
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteValue(nValue);
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

        public void runString(ref string nValue, string nName, string nOptimal = default(string))
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteValue(nValue);
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

        public void runFloat(ref float nValue, string nName, float nOptimal = default(float))
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteValue(nValue);
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

        public void runDouble(ref double nValue, string nName, double nOptimal = default(double))
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteValue(nValue);
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

        public void runDateTime(ref DateTime nValue, string nName, DateTime nOptimal = default(DateTime))
        {
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteValue(nValue);
        }

        public void runStream<T>(ref T nValue, string nName, T nOptimal = default(T)) where T : IStream
        {
            if (null == nValue) return;
            mJsonTextWriter.WritePropertyName(nName);
            mJsonTextWriter.WriteStartObject();
            nValue.serialize(this);
            mJsonTextWriter.WriteEndObject();
        }

        public void runStreams<T>(ref List<T> nValue, string nNames, string nName) where T : IStream
        {
            mJsonTextWriter.WritePropertyName(nNames);
            mJsonTextWriter.WriteStartArray();
            foreach (T i in nValue)
            {
                T t_ = i;
                mJsonTextWriter.WriteStartObject();
                t_.serialize(this);
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
                t_.serialize(this);
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

        JsonTextWriter mJsonTextWriter;
        StringBuilder mStringBuilder;
        StringWriter mStringWriter;
    }
}
