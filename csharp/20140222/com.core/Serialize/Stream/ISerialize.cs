using System;
using System.Collections.Generic;

namespace com.core
{
    public interface ISerialize
    {
        void runBool(ref bool nValue, string nName, bool nOptimal = default(bool));

        void runInt8(ref sbyte nValue, string nName, sbyte nOptimal = default(sbyte));
        void runInt8Count(ref List<sbyte> nValue, string nNames, string nName, int nCount);
        void runInt8s(ref List<sbyte> nValue, string nNames, string nName);
        void runInt8Semi(ref List<sbyte> nValue, string nName);

        void runInt16(ref short nValue, string nName, short nOptimal = default(short));
        void runInt16Count(ref List<short> nValue, string nNames, string nName, int nCount);
        void runInt16s(ref List<short> nValue, string nNames, string nName);
        void runInt16Semi(ref List<short> nValue, string nName);

        void runInt32(ref int nValue, string nName, int nOptimal = default(int));
        void runInt32Count(ref List<int> nValue, string nNames, string nName, int nCount);
        void runInt32s(ref List<int> nValue, string nNames, string nName);
        void runInt32Semi(ref List<int> nValue, string nName);

        void runCrc32(ref int nValue, string nName, int nOptimal = default(int));
        void runCrc32Count(ref List<int> nValue, string nNames, string nName, int nCount);
        void runCrc32s(ref List<int> nValue, string nNames, string nName);
        void runCrc32Semi(ref List<int> nValue, string nName);

        void runInt64(ref long nValue, string nName, long nOptimal = default(long));
        void runInt64Count(ref List<long> nValue, string nNames, string nName, int nCount);
        void runInt64s(ref List<long> nValue, string nNames, string nName);
        void runInt64Semi(ref List<long> nValue, string nName);

        void runString(ref string nValue, string nName, string nOptimal = default(string));
        void runStringCount(ref List<string> nValue, string nNames, string nName, int nCount);
        void runStrings(ref List<string> nValue, string nNames, string nName);
        void runStringSemi(ref List<string> nValue, string nName);

        void runFloat(ref float nValue, string nName, float nOptimal = default(float));
        void runFloatCount(ref List<float> nValue, string nNames, string nName, int nCount);
        void runFloats(ref List<float> nValue, string nNames, string nName);
        void runFloatSemi(ref List<float> nValue, string nName);

        void runDouble(ref double nValue, string nName, double nOptimal = default(double));
        void runDoubleCount(ref List<double> nValue, string nNames, string nName, int nCount);
        void runDoubles(ref List<double> nValue, string nNames, string nName);
        void runDoubleSemi(ref List<double> nValue, string nName);

        void runDateTime(ref DateTime nValue, string nName, DateTime nOptimal = default(DateTime));

        void runStream<T>(ref T nValue, string nName, int nCount = 0, T nOptimal = default(T)) where T : IStream;
        void runStreamCount<T>(ref List<T> nValue, string nNames, string nName, int nCount) where T : IStream;
        void runStreams<T>(ref List<T> nValue, string nNames, string nName) where T : IStream;
        void runIntStreams<T>(ref Dictionary<int, T> nValue, string nNames, string nName) where T : IIntStream;

        void openUrl(string nUrl);
        void selectStream(string nStreamName);
        void runClose();
    }
}
