using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunmerx.Common.Stream
{
    public interface IFrameProcess<in T>
    {
        byte[] ToByteArray(T inparam);
    }
    public interface IUnitConfig
    {
        /// <summary>
        /// 元在数组的位置
        /// </summary>
        UnitPos BytePos
        {
            get;
        }
        /// <summary>
        /// 是否时固定值
        /// </summary>
        bool IsFixed
        {
            get;
        }
        /// <summary>
        /// 元的长度
        /// </summary>
        byte UnitLength
        {

            get;
        }
        Unit FixedData
        {
            get;
        }
    }
    public enum UnitPos
    {
        Head=0,
        Tail=9,
        Offset=1,
        Content=2
    }
    public struct Unit
    {
        public byte byte0;
        public byte byte1;
        public byte byte2;
        public byte byte3;
        public byte byte4;
        public byte byte5;
        public byte byte6;
        public byte byte7;
    }
}
