using System.Collections.Generic;

namespace com.stdlib
{
    public interface ISerialize
    {
        void runBool(ref bool nValue, string nName, bool nOptimal = default(bool));

        void runInt8(ref sbyte nValue, string nName, sbyte nOptimal = default(sbyte));
        void runInt8s(ref List<sbyte> nValue, string nName);

        void runInt16(ref short nValue, string nName, short nOptimal = default(short));
        void runInt16s(ref List<short> nValue, string nName);

        void runInt32(ref int nValue, string nName, int nOptimal = default(int));
        void runInt32s(ref List<int> nValue, string nName);

        void runInt64(ref long nValue, string nName, long nOptimal = default(long));
        void runInt64s(ref List<long> nValue, string nName);

        void runString(ref string nValue, string nName, string nOptimal = default(string));
        void runStrings(ref List<string> nValue, string nName);

        void runFloat(ref float nValue, string nName, float nOptimal = default(float));
        void runFloats(ref List<float> nValue, string nName);

        void runDouble(ref double nValue, string nName, double nOptimal = default(double));
        void runDoubles(ref List<double> nValue, string nName, );

        void runStream<T>(ref T nValue, string nName, T nOptimal = default(T)) where T : IStream;
        void runStreams<T>(ref List<T> nValue, string nName) where T : IStream;

        void _openUrl(string nUrl);
        void _selectStream(string nStreamName);
        void _runClose();
    }
}
