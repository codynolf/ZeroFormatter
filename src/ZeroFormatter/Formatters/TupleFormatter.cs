﻿#if !UNITY

using System;
using ZeroFormatter.Internal;
using ZeroFormatter.Segments;

namespace ZeroFormatter.Formatters
{
    // Layout: [hasValue:1][T1, T2...]



    
    internal class TupleFormatter<TTypeResolver, T1> : Formatter<TTypeResolver, Tuple<T1>>
        where TTypeResolver : ITypeResolver, new()
    {
        readonly Formatter<TTypeResolver, T1> formatter1;
        

        
        public TupleFormatter()
        {
            this.formatter1 = Formatter<TTypeResolver, T1>.Default;
   
        }

        public override bool NoUseDirtyTracker
        {
            get
            {
                return formatter1.NoUseDirtyTracker
        
                ;
            }
        }

        public override int? GetLength()
        {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, Tuple<T1> value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value != null);
            if (value != null)
            {
                var startOffset = offset;
                offset += 1;
                offset += this.formatter1.Serialize(ref bytes, offset, value.Item1);
                return offset - startOffset;
            }
            else
            {
                return 1;
            }
        }

        public override Tuple<T1> Deserialize(ref byte[] bytes, int offset, DirtyTracker tracker, out int byteSize)
        {
            byteSize = 1;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;
            
            offset += 1;
            int size;

            var item1 = this.formatter1.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;

            return new Tuple<T1>(item1);
        }
    }



    
    internal class TupleFormatter<TTypeResolver, T1, T2> : Formatter<TTypeResolver, Tuple<T1, T2>>
        where TTypeResolver : ITypeResolver, new()
    {
        readonly Formatter<TTypeResolver, T1> formatter1;
        readonly Formatter<TTypeResolver, T2> formatter2;
        

        
        public TupleFormatter()
        {
            this.formatter1 = Formatter<TTypeResolver, T1>.Default;
            this.formatter2 = Formatter<TTypeResolver, T2>.Default;
   
        }

        public override bool NoUseDirtyTracker
        {
            get
            {
                return formatter1.NoUseDirtyTracker
                    && formatter2.NoUseDirtyTracker
        
                ;
            }
        }

        public override int? GetLength()
        {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, Tuple<T1, T2> value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value != null);
            if (value != null)
            {
                var startOffset = offset;
                offset += 1;
                offset += this.formatter1.Serialize(ref bytes, offset, value.Item1);
                offset += this.formatter2.Serialize(ref bytes, offset, value.Item2);
                return offset - startOffset;
            }
            else
            {
                return 1;
            }
        }

        public override Tuple<T1, T2> Deserialize(ref byte[] bytes, int offset, DirtyTracker tracker, out int byteSize)
        {
            byteSize = 1;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;
            
            offset += 1;
            int size;

            var item1 = this.formatter1.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item2 = this.formatter2.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;

            return new Tuple<T1, T2>(item1, item2);
        }
    }



    
    internal class TupleFormatter<TTypeResolver, T1, T2, T3> : Formatter<TTypeResolver, Tuple<T1, T2, T3>>
        where TTypeResolver : ITypeResolver, new()
    {
        readonly Formatter<TTypeResolver, T1> formatter1;
        readonly Formatter<TTypeResolver, T2> formatter2;
        readonly Formatter<TTypeResolver, T3> formatter3;
        

        
        public TupleFormatter()
        {
            this.formatter1 = Formatter<TTypeResolver, T1>.Default;
            this.formatter2 = Formatter<TTypeResolver, T2>.Default;
            this.formatter3 = Formatter<TTypeResolver, T3>.Default;
   
        }

        public override bool NoUseDirtyTracker
        {
            get
            {
                return formatter1.NoUseDirtyTracker
                    && formatter2.NoUseDirtyTracker
                    && formatter3.NoUseDirtyTracker
        
                ;
            }
        }

        public override int? GetLength()
        {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, Tuple<T1, T2, T3> value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value != null);
            if (value != null)
            {
                var startOffset = offset;
                offset += 1;
                offset += this.formatter1.Serialize(ref bytes, offset, value.Item1);
                offset += this.formatter2.Serialize(ref bytes, offset, value.Item2);
                offset += this.formatter3.Serialize(ref bytes, offset, value.Item3);
                return offset - startOffset;
            }
            else
            {
                return 1;
            }
        }

        public override Tuple<T1, T2, T3> Deserialize(ref byte[] bytes, int offset, DirtyTracker tracker, out int byteSize)
        {
            byteSize = 1;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;
            
            offset += 1;
            int size;

            var item1 = this.formatter1.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item2 = this.formatter2.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item3 = this.formatter3.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;

            return new Tuple<T1, T2, T3>(item1, item2, item3);
        }
    }



    
    internal class TupleFormatter<TTypeResolver, T1, T2, T3, T4> : Formatter<TTypeResolver, Tuple<T1, T2, T3, T4>>
        where TTypeResolver : ITypeResolver, new()
    {
        readonly Formatter<TTypeResolver, T1> formatter1;
        readonly Formatter<TTypeResolver, T2> formatter2;
        readonly Formatter<TTypeResolver, T3> formatter3;
        readonly Formatter<TTypeResolver, T4> formatter4;
        

        
        public TupleFormatter()
        {
            this.formatter1 = Formatter<TTypeResolver, T1>.Default;
            this.formatter2 = Formatter<TTypeResolver, T2>.Default;
            this.formatter3 = Formatter<TTypeResolver, T3>.Default;
            this.formatter4 = Formatter<TTypeResolver, T4>.Default;
   
        }

        public override bool NoUseDirtyTracker
        {
            get
            {
                return formatter1.NoUseDirtyTracker
                    && formatter2.NoUseDirtyTracker
                    && formatter3.NoUseDirtyTracker
                    && formatter4.NoUseDirtyTracker
        
                ;
            }
        }

        public override int? GetLength()
        {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, Tuple<T1, T2, T3, T4> value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value != null);
            if (value != null)
            {
                var startOffset = offset;
                offset += 1;
                offset += this.formatter1.Serialize(ref bytes, offset, value.Item1);
                offset += this.formatter2.Serialize(ref bytes, offset, value.Item2);
                offset += this.formatter3.Serialize(ref bytes, offset, value.Item3);
                offset += this.formatter4.Serialize(ref bytes, offset, value.Item4);
                return offset - startOffset;
            }
            else
            {
                return 1;
            }
        }

        public override Tuple<T1, T2, T3, T4> Deserialize(ref byte[] bytes, int offset, DirtyTracker tracker, out int byteSize)
        {
            byteSize = 1;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;
            
            offset += 1;
            int size;

            var item1 = this.formatter1.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item2 = this.formatter2.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item3 = this.formatter3.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item4 = this.formatter4.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;

            return new Tuple<T1, T2, T3, T4>(item1, item2, item3, item4);
        }
    }



    
    internal class TupleFormatter<TTypeResolver, T1, T2, T3, T4, T5> : Formatter<TTypeResolver, Tuple<T1, T2, T3, T4, T5>>
        where TTypeResolver : ITypeResolver, new()
    {
        readonly Formatter<TTypeResolver, T1> formatter1;
        readonly Formatter<TTypeResolver, T2> formatter2;
        readonly Formatter<TTypeResolver, T3> formatter3;
        readonly Formatter<TTypeResolver, T4> formatter4;
        readonly Formatter<TTypeResolver, T5> formatter5;
        

        
        public TupleFormatter()
        {
            this.formatter1 = Formatter<TTypeResolver, T1>.Default;
            this.formatter2 = Formatter<TTypeResolver, T2>.Default;
            this.formatter3 = Formatter<TTypeResolver, T3>.Default;
            this.formatter4 = Formatter<TTypeResolver, T4>.Default;
            this.formatter5 = Formatter<TTypeResolver, T5>.Default;
   
        }

        public override bool NoUseDirtyTracker
        {
            get
            {
                return formatter1.NoUseDirtyTracker
                    && formatter2.NoUseDirtyTracker
                    && formatter3.NoUseDirtyTracker
                    && formatter4.NoUseDirtyTracker
                    && formatter5.NoUseDirtyTracker
        
                ;
            }
        }

        public override int? GetLength()
        {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, Tuple<T1, T2, T3, T4, T5> value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value != null);
            if (value != null)
            {
                var startOffset = offset;
                offset += 1;
                offset += this.formatter1.Serialize(ref bytes, offset, value.Item1);
                offset += this.formatter2.Serialize(ref bytes, offset, value.Item2);
                offset += this.formatter3.Serialize(ref bytes, offset, value.Item3);
                offset += this.formatter4.Serialize(ref bytes, offset, value.Item4);
                offset += this.formatter5.Serialize(ref bytes, offset, value.Item5);
                return offset - startOffset;
            }
            else
            {
                return 1;
            }
        }

        public override Tuple<T1, T2, T3, T4, T5> Deserialize(ref byte[] bytes, int offset, DirtyTracker tracker, out int byteSize)
        {
            byteSize = 1;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;
            
            offset += 1;
            int size;

            var item1 = this.formatter1.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item2 = this.formatter2.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item3 = this.formatter3.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item4 = this.formatter4.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item5 = this.formatter5.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;

            return new Tuple<T1, T2, T3, T4, T5>(item1, item2, item3, item4, item5);
        }
    }



    
    internal class TupleFormatter<TTypeResolver, T1, T2, T3, T4, T5, T6> : Formatter<TTypeResolver, Tuple<T1, T2, T3, T4, T5, T6>>
        where TTypeResolver : ITypeResolver, new()
    {
        readonly Formatter<TTypeResolver, T1> formatter1;
        readonly Formatter<TTypeResolver, T2> formatter2;
        readonly Formatter<TTypeResolver, T3> formatter3;
        readonly Formatter<TTypeResolver, T4> formatter4;
        readonly Formatter<TTypeResolver, T5> formatter5;
        readonly Formatter<TTypeResolver, T6> formatter6;
        

        
        public TupleFormatter()
        {
            this.formatter1 = Formatter<TTypeResolver, T1>.Default;
            this.formatter2 = Formatter<TTypeResolver, T2>.Default;
            this.formatter3 = Formatter<TTypeResolver, T3>.Default;
            this.formatter4 = Formatter<TTypeResolver, T4>.Default;
            this.formatter5 = Formatter<TTypeResolver, T5>.Default;
            this.formatter6 = Formatter<TTypeResolver, T6>.Default;
   
        }

        public override bool NoUseDirtyTracker
        {
            get
            {
                return formatter1.NoUseDirtyTracker
                    && formatter2.NoUseDirtyTracker
                    && formatter3.NoUseDirtyTracker
                    && formatter4.NoUseDirtyTracker
                    && formatter5.NoUseDirtyTracker
                    && formatter6.NoUseDirtyTracker
        
                ;
            }
        }

        public override int? GetLength()
        {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, Tuple<T1, T2, T3, T4, T5, T6> value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value != null);
            if (value != null)
            {
                var startOffset = offset;
                offset += 1;
                offset += this.formatter1.Serialize(ref bytes, offset, value.Item1);
                offset += this.formatter2.Serialize(ref bytes, offset, value.Item2);
                offset += this.formatter3.Serialize(ref bytes, offset, value.Item3);
                offset += this.formatter4.Serialize(ref bytes, offset, value.Item4);
                offset += this.formatter5.Serialize(ref bytes, offset, value.Item5);
                offset += this.formatter6.Serialize(ref bytes, offset, value.Item6);
                return offset - startOffset;
            }
            else
            {
                return 1;
            }
        }

        public override Tuple<T1, T2, T3, T4, T5, T6> Deserialize(ref byte[] bytes, int offset, DirtyTracker tracker, out int byteSize)
        {
            byteSize = 1;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;
            
            offset += 1;
            int size;

            var item1 = this.formatter1.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item2 = this.formatter2.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item3 = this.formatter3.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item4 = this.formatter4.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item5 = this.formatter5.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item6 = this.formatter6.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;

            return new Tuple<T1, T2, T3, T4, T5, T6>(item1, item2, item3, item4, item5, item6);
        }
    }



    
    internal class TupleFormatter<TTypeResolver, T1, T2, T3, T4, T5, T6, T7> : Formatter<TTypeResolver, Tuple<T1, T2, T3, T4, T5, T6, T7>>
        where TTypeResolver : ITypeResolver, new()
    {
        readonly Formatter<TTypeResolver, T1> formatter1;
        readonly Formatter<TTypeResolver, T2> formatter2;
        readonly Formatter<TTypeResolver, T3> formatter3;
        readonly Formatter<TTypeResolver, T4> formatter4;
        readonly Formatter<TTypeResolver, T5> formatter5;
        readonly Formatter<TTypeResolver, T6> formatter6;
        readonly Formatter<TTypeResolver, T7> formatter7;
        

        
        public TupleFormatter()
        {
            this.formatter1 = Formatter<TTypeResolver, T1>.Default;
            this.formatter2 = Formatter<TTypeResolver, T2>.Default;
            this.formatter3 = Formatter<TTypeResolver, T3>.Default;
            this.formatter4 = Formatter<TTypeResolver, T4>.Default;
            this.formatter5 = Formatter<TTypeResolver, T5>.Default;
            this.formatter6 = Formatter<TTypeResolver, T6>.Default;
            this.formatter7 = Formatter<TTypeResolver, T7>.Default;
   
        }

        public override bool NoUseDirtyTracker
        {
            get
            {
                return formatter1.NoUseDirtyTracker
                    && formatter2.NoUseDirtyTracker
                    && formatter3.NoUseDirtyTracker
                    && formatter4.NoUseDirtyTracker
                    && formatter5.NoUseDirtyTracker
                    && formatter6.NoUseDirtyTracker
                    && formatter7.NoUseDirtyTracker
        
                ;
            }
        }

        public override int? GetLength()
        {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, Tuple<T1, T2, T3, T4, T5, T6, T7> value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value != null);
            if (value != null)
            {
                var startOffset = offset;
                offset += 1;
                offset += this.formatter1.Serialize(ref bytes, offset, value.Item1);
                offset += this.formatter2.Serialize(ref bytes, offset, value.Item2);
                offset += this.formatter3.Serialize(ref bytes, offset, value.Item3);
                offset += this.formatter4.Serialize(ref bytes, offset, value.Item4);
                offset += this.formatter5.Serialize(ref bytes, offset, value.Item5);
                offset += this.formatter6.Serialize(ref bytes, offset, value.Item6);
                offset += this.formatter7.Serialize(ref bytes, offset, value.Item7);
                return offset - startOffset;
            }
            else
            {
                return 1;
            }
        }

        public override Tuple<T1, T2, T3, T4, T5, T6, T7> Deserialize(ref byte[] bytes, int offset, DirtyTracker tracker, out int byteSize)
        {
            byteSize = 1;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;
            
            offset += 1;
            int size;

            var item1 = this.formatter1.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item2 = this.formatter2.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item3 = this.formatter3.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item4 = this.formatter4.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item5 = this.formatter5.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item6 = this.formatter6.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item7 = this.formatter7.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;

            return new Tuple<T1, T2, T3, T4, T5, T6, T7>(item1, item2, item3, item4, item5, item6, item7);
        }
    }



    
    internal class TupleFormatter<TTypeResolver, T1, T2, T3, T4, T5, T6, T7, TRest> : Formatter<TTypeResolver, Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>>
        where TTypeResolver : ITypeResolver, new()
    {
        readonly Formatter<TTypeResolver, T1> formatter1;
        readonly Formatter<TTypeResolver, T2> formatter2;
        readonly Formatter<TTypeResolver, T3> formatter3;
        readonly Formatter<TTypeResolver, T4> formatter4;
        readonly Formatter<TTypeResolver, T5> formatter5;
        readonly Formatter<TTypeResolver, T6> formatter6;
        readonly Formatter<TTypeResolver, T7> formatter7;
        readonly Formatter<TTypeResolver, TRest> formatter8;
        

        
        public TupleFormatter()
        {
            this.formatter1 = Formatter<TTypeResolver, T1>.Default;
            this.formatter2 = Formatter<TTypeResolver, T2>.Default;
            this.formatter3 = Formatter<TTypeResolver, T3>.Default;
            this.formatter4 = Formatter<TTypeResolver, T4>.Default;
            this.formatter5 = Formatter<TTypeResolver, T5>.Default;
            this.formatter6 = Formatter<TTypeResolver, T6>.Default;
            this.formatter7 = Formatter<TTypeResolver, T7>.Default;
            this.formatter8 = Formatter<TTypeResolver, TRest>.Default;
   
        }

        public override bool NoUseDirtyTracker
        {
            get
            {
                return formatter1.NoUseDirtyTracker
                    && formatter2.NoUseDirtyTracker
                    && formatter3.NoUseDirtyTracker
                    && formatter4.NoUseDirtyTracker
                    && formatter5.NoUseDirtyTracker
                    && formatter6.NoUseDirtyTracker
                    && formatter7.NoUseDirtyTracker
                    && formatter8.NoUseDirtyTracker
        
                ;
            }
        }

        public override int? GetLength()
        {
            return null;
        }

        public override int Serialize(ref byte[] bytes, int offset, Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> value)
        {
            BinaryUtil.WriteBoolean(ref bytes, offset, value != null);
            if (value != null)
            {
                var startOffset = offset;
                offset += 1;
                offset += this.formatter1.Serialize(ref bytes, offset, value.Item1);
                offset += this.formatter2.Serialize(ref bytes, offset, value.Item2);
                offset += this.formatter3.Serialize(ref bytes, offset, value.Item3);
                offset += this.formatter4.Serialize(ref bytes, offset, value.Item4);
                offset += this.formatter5.Serialize(ref bytes, offset, value.Item5);
                offset += this.formatter6.Serialize(ref bytes, offset, value.Item6);
                offset += this.formatter7.Serialize(ref bytes, offset, value.Item7);
                offset += this.formatter8.Serialize(ref bytes, offset, value.Rest);
                return offset - startOffset;
            }
            else
            {
                return 1;
            }
        }

        public override Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> Deserialize(ref byte[] bytes, int offset, DirtyTracker tracker, out int byteSize)
        {
            byteSize = 1;
            var hasValue = BinaryUtil.ReadBoolean(ref bytes, offset);
            if (!hasValue) return null;
            
            offset += 1;
            int size;

            var item1 = this.formatter1.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item2 = this.formatter2.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item3 = this.formatter3.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item4 = this.formatter4.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item5 = this.formatter5.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item6 = this.formatter6.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item7 = this.formatter7.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;
            var item8 = this.formatter8.Deserialize(ref bytes, offset, tracker, out size);
            offset += size;
            byteSize += size;

            return new Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>(item1, item2, item3, item4, item5, item6, item7, item8);
        }
    }


}

#endif