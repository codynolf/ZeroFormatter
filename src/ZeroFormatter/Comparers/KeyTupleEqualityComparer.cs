﻿using ZeroFormatter;

namespace ZeroFormatter.Comparers
{
    public class KeyTupleEqualityComparer<T1> : IEqualityComparer<KeyTuple<T1>>
    {
        public KeyTupleEqualityComparer()
        {

        }

        public bool Equals(KeyTuple<T1> x, KeyTuple<T1> y)
        {
            return ZeroFormatterEqualityComparer<T1>.Default.Equals(x.Item1, y.Item1);
        }

        public int GetHashCode(KeyTuple<T1> obj)
        {
            if(obj.Item1 == null)
                throw new System.ArgumentNullException("Item1");
            return ZeroFormatterEqualityComparer<T1>.Default.GetHashCode(obj.Item1);
        }
    }


    
    public class KeyTupleEqualityComparer<T1, T2> : IEqualityComparer<KeyTuple<T1, T2>>
    {

        
        public KeyTupleEqualityComparer()
        {

        }

        public bool Equals(KeyTuple<T1, T2> x, KeyTuple<T1, T2> y)
        {
            var comparer1 = ZeroFormatterEqualityComparer<T1>.Default;
            var comparer2 = ZeroFormatterEqualityComparer<T2>.Default;

            return comparer1.Equals(x.Item1, y.Item1) &&
                comparer2.Equals(x.Item2, y.Item2);
        }

        public int GetHashCode(KeyTuple<T1, T2> obj)
        {
            if(obj.Item1 == null)
                throw new System.ArgumentNullException("Item1");
            if(obj.Item2 == null)
                throw new System.ArgumentNullException("Item2");

            var comparer1 = ZeroFormatterEqualityComparer<T1>.Default;
            var comparer2 = ZeroFormatterEqualityComparer<T2>.Default;

            int h0;
            h0 = comparer1.GetHashCode(obj.Item1);
            h0 = (h0 << 5) + h0 ^ comparer2.GetHashCode(obj.Item2);
            return h0;
        }
    }


    
    public class KeyTupleEqualityComparer<T1, T2, T3> : IEqualityComparer<KeyTuple<T1, T2, T3>>
    {

        
        public KeyTupleEqualityComparer()
        {

        }

        public bool Equals(KeyTuple<T1, T2, T3> x, KeyTuple<T1, T2, T3> y)
        {

            var comparer1 = ZeroFormatterEqualityComparer<T1>.Default;
            var comparer2 = ZeroFormatterEqualityComparer<T2>.Default;
            var comparer3 = ZeroFormatterEqualityComparer<T3>.Default;

            return comparer1.Equals(x.Item1, y.Item1) &&
                comparer2.Equals(x.Item2, y.Item2) &&
                comparer3.Equals(x.Item3, y.Item3);
        }

        public int GetHashCode(KeyTuple<T1, T2, T3> obj)
        {
            if(obj.Item1 == null)
                throw new System.ArgumentNullException("Item1");
            if(obj.Item2 == null)
                throw new System.ArgumentNullException("Item2");
            if(obj.Item3 == null)
                throw new System.ArgumentNullException("Item3");

            var comparer1 = ZeroFormatterEqualityComparer<T1>.Default;
            var comparer2 = ZeroFormatterEqualityComparer<T2>.Default;
            var comparer3 = ZeroFormatterEqualityComparer<T3>.Default;

            int h0;
            h0 = comparer1.GetHashCode(obj.Item1);
            h0 = (h0 << 5) + h0 ^ comparer2.GetHashCode(obj.Item2);
            h0 = (h0 << 5) + h0 ^ comparer3.GetHashCode(obj.Item3);
            return h0;
        }
    }


    
    public class KeyTupleEqualityComparer<T1, T2, T3, T4> : IEqualityComparer<KeyTuple<T1, T2, T3, T4>>
    {

        
        public KeyTupleEqualityComparer()
        {

        }

        public bool Equals(KeyTuple<T1, T2, T3, T4> x, KeyTuple<T1, T2, T3, T4> y)
        {

            var comparer1 = ZeroFormatterEqualityComparer<T1>.Default;
            var comparer2 = ZeroFormatterEqualityComparer<T2>.Default;
            var comparer3 = ZeroFormatterEqualityComparer<T3>.Default;
            var comparer4 = ZeroFormatterEqualityComparer<T4>.Default;

            return comparer1.Equals(x.Item1, y.Item1) &&
                comparer2.Equals(x.Item2, y.Item2) &&
                comparer3.Equals(x.Item3, y.Item3) &&
                comparer4.Equals(x.Item4, y.Item4);
        }

        public int GetHashCode(KeyTuple<T1, T2, T3, T4> obj)
        {
            if(obj.Item1 == null)
                throw new System.ArgumentNullException("Item1");
            if(obj.Item2 == null)
                throw new System.ArgumentNullException("Item2");
            if(obj.Item3 == null)
                throw new System.ArgumentNullException("Item3");
            if(obj.Item4 == null)
                throw new System.ArgumentNullException("Item4");

            var comparer1 = ZeroFormatterEqualityComparer<T1>.Default;
            var comparer2 = ZeroFormatterEqualityComparer<T2>.Default;
            var comparer3 = ZeroFormatterEqualityComparer<T3>.Default;
            var comparer4 = ZeroFormatterEqualityComparer<T4>.Default;

            int h0, h1;
            h0 = comparer1.GetHashCode(obj.Item1);
            h0 = (h0 << 5) + h0 ^ comparer2.GetHashCode(obj.Item2);
            h1 = comparer3.GetHashCode(obj.Item3);
            h1 = (h1 << 5) + h1 ^ comparer4.GetHashCode(obj.Item4);
            h0 = (h0 << 5) + h0 ^ h1;
            return h0;
        }
    }


    
    public class KeyTupleEqualityComparer<T1, T2, T3, T4, T5> : IEqualityComparer<KeyTuple<T1, T2, T3, T4, T5>>
    {


        
        public KeyTupleEqualityComparer()
        {

        }

        public bool Equals(KeyTuple<T1, T2, T3, T4, T5> x, KeyTuple<T1, T2, T3, T4, T5> y)
        {

            var comparer1 = ZeroFormatterEqualityComparer<T1>.Default;
            var comparer2 = ZeroFormatterEqualityComparer<T2>.Default;
            var comparer3 = ZeroFormatterEqualityComparer<T3>.Default;
            var comparer4 = ZeroFormatterEqualityComparer<T4>.Default;
            var comparer5 = ZeroFormatterEqualityComparer<T5>.Default;

            return comparer1.Equals(x.Item1, y.Item1) &&
                comparer2.Equals(x.Item2, y.Item2) &&
                comparer3.Equals(x.Item3, y.Item3) &&
                comparer4.Equals(x.Item4, y.Item4) &&
                comparer5.Equals(x.Item5, y.Item5);
        }

        public int GetHashCode(KeyTuple<T1, T2, T3, T4, T5> obj)
        {
            if(obj.Item1 == null)
                throw new System.ArgumentNullException("Item1");
            if(obj.Item2 == null)
                throw new System.ArgumentNullException("Item2");
            if(obj.Item3 == null)
                throw new System.ArgumentNullException("Item3");
            if(obj.Item4 == null)
                throw new System.ArgumentNullException("Item4");
            if(obj.Item5 == null)
                throw new System.ArgumentNullException("Item5");

            var comparer1 = ZeroFormatterEqualityComparer<T1>.Default;
            var comparer2 = ZeroFormatterEqualityComparer<T2>.Default;
            var comparer3 = ZeroFormatterEqualityComparer<T3>.Default;
            var comparer4 = ZeroFormatterEqualityComparer<T4>.Default;
            var comparer5 = ZeroFormatterEqualityComparer<T5>.Default;

            int h0, h1;
            h0 = comparer1.GetHashCode(obj.Item1);
            h0 = (h0 << 5) + h0 ^ comparer2.GetHashCode(obj.Item2);
            h1 = comparer3.GetHashCode(obj.Item3);
            h1 = (h1 << 5) + h1 ^ comparer4.GetHashCode(obj.Item4);
            h0 = (h0 << 5) + h0 ^ h1;
            h0 = (h0 << 5) + h0 ^ comparer5.GetHashCode(obj.Item5);
            return h0;
        }
    }


    
    public class KeyTupleEqualityComparer<T1, T2, T3, T4, T5, T6> : IEqualityComparer<KeyTuple<T1, T2, T3, T4, T5, T6>>
    {
        
        public KeyTupleEqualityComparer()
        {

        }

        public bool Equals(KeyTuple<T1, T2, T3, T4, T5, T6> x, KeyTuple<T1, T2, T3, T4, T5, T6> y)
        {

            var comparer1 = ZeroFormatterEqualityComparer<T1>.Default;
            var comparer2 = ZeroFormatterEqualityComparer<T2>.Default;
            var comparer3 = ZeroFormatterEqualityComparer<T3>.Default;
            var comparer4 = ZeroFormatterEqualityComparer<T4>.Default;
            var comparer5 = ZeroFormatterEqualityComparer<T5>.Default;
            var comparer6 = ZeroFormatterEqualityComparer<T6>.Default;

            return comparer1.Equals(x.Item1, y.Item1) &&
                comparer2.Equals(x.Item2, y.Item2) &&
                comparer3.Equals(x.Item3, y.Item3) &&
                comparer4.Equals(x.Item4, y.Item4) &&
                comparer5.Equals(x.Item5, y.Item5) &&
                comparer6.Equals(x.Item6, y.Item6);
        }

        public int GetHashCode(KeyTuple<T1, T2, T3, T4, T5, T6> obj)
        {
            if(obj.Item1 == null)
                throw new System.ArgumentNullException("Item1");
            if(obj.Item2 == null)
                throw new System.ArgumentNullException("Item2");
            if(obj.Item3 == null)
                throw new System.ArgumentNullException("Item3");
            if(obj.Item4 == null)
                throw new System.ArgumentNullException("Item4");
            if(obj.Item5 == null)
                throw new System.ArgumentNullException("Item5");
            if(obj.Item6 == null)
                throw new System.ArgumentNullException("Item6");

            var comparer1 = ZeroFormatterEqualityComparer<T1>.Default;
            var comparer2 = ZeroFormatterEqualityComparer<T2>.Default;
            var comparer3 = ZeroFormatterEqualityComparer<T3>.Default;
            var comparer4 = ZeroFormatterEqualityComparer<T4>.Default;
            var comparer5 = ZeroFormatterEqualityComparer<T5>.Default;
            var comparer6 = ZeroFormatterEqualityComparer<T6>.Default;

            int h0, h1;
            h0 = comparer1.GetHashCode(obj.Item1);
            h0 = (h0 << 5) + h0 ^ comparer2.GetHashCode(obj.Item2);
            h1 = comparer3.GetHashCode(obj.Item3);
            h1 = (h1 << 5) + h1 ^ comparer4.GetHashCode(obj.Item4);
            h0 = (h0 << 5) + h0 ^ h1;
            h1 = comparer5.GetHashCode(obj.Item5);
            h1 = (h1 << 5) + h1 ^ comparer6.GetHashCode(obj.Item6);
            h0 = (h0 << 5) + h0 ^ h1;
            return h0;
        }
    }


    
    public class KeyTupleEqualityComparer<T1, T2, T3, T4, T5, T6, T7> : IEqualityComparer<KeyTuple<T1, T2, T3, T4, T5, T6, T7>>
    {

        
        public KeyTupleEqualityComparer()
        {

        }


        public bool Equals(KeyTuple<T1, T2, T3, T4, T5, T6, T7> x, KeyTuple<T1, T2, T3, T4, T5, T6, T7> y)
        {

            var comparer1 = ZeroFormatterEqualityComparer<T1>.Default;
            var comparer2 = ZeroFormatterEqualityComparer<T2>.Default;
            var comparer3 = ZeroFormatterEqualityComparer<T3>.Default;
            var comparer4 = ZeroFormatterEqualityComparer<T4>.Default;
            var comparer5 = ZeroFormatterEqualityComparer<T5>.Default;
            var comparer6 = ZeroFormatterEqualityComparer<T6>.Default;
            var comparer7 = ZeroFormatterEqualityComparer<T7>.Default;

            return comparer1.Equals(x.Item1, y.Item1) &&
                comparer2.Equals(x.Item2, y.Item2) &&
                comparer3.Equals(x.Item3, y.Item3) &&
                comparer4.Equals(x.Item4, y.Item4) &&
                comparer5.Equals(x.Item5, y.Item5) &&
                comparer6.Equals(x.Item6, y.Item6) &&
                comparer7.Equals(x.Item7, y.Item7);
        }

        public int GetHashCode(KeyTuple<T1, T2, T3, T4, T5, T6, T7> obj)
        {
            if(obj.Item1 == null)
                throw new System.ArgumentNullException("Item1");
            if(obj.Item2 == null)
                throw new System.ArgumentNullException("Item2");
            if(obj.Item3 == null)
                throw new System.ArgumentNullException("Item3");
            if(obj.Item4 == null)
                throw new System.ArgumentNullException("Item4");
            if(obj.Item5 == null)
                throw new System.ArgumentNullException("Item5");
            if(obj.Item6 == null)
                throw new System.ArgumentNullException("Item6");
            if(obj.Item7 == null)
                throw new System.ArgumentNullException("Item7");

            var comparer1 = ZeroFormatterEqualityComparer<T1>.Default;
            var comparer2 = ZeroFormatterEqualityComparer<T2>.Default;
            var comparer3 = ZeroFormatterEqualityComparer<T3>.Default;
            var comparer4 = ZeroFormatterEqualityComparer<T4>.Default;
            var comparer5 = ZeroFormatterEqualityComparer<T5>.Default;
            var comparer6 = ZeroFormatterEqualityComparer<T6>.Default;
            var comparer7 = ZeroFormatterEqualityComparer<T7>.Default;

            int h0, h1;
            h0 = comparer1.GetHashCode(obj.Item1);
            h0 = (h0 << 5) + h0 ^ comparer2.GetHashCode(obj.Item2);
            h1 = comparer3.GetHashCode(obj.Item3);
            h1 = (h1 << 5) + h1 ^ comparer4.GetHashCode(obj.Item4);
            h0 = (h0 << 5) + h0 ^ h1;
            h1 = comparer5.GetHashCode(obj.Item5);
            h1 = (h1 << 5) + h1 ^ comparer6.GetHashCode(obj.Item6);
            h1 = (h1 << 5) + h1 ^ comparer7.GetHashCode(obj.Item7);
            h0 = (h0 << 5) + h0 ^ h1;
            return h0;
        }
    }


    
    public class KeyTupleEqualityComparer<T1, T2, T3, T4, T5, T6, T7, TRest> : IEqualityComparer<KeyTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>
    {
        
        public KeyTupleEqualityComparer()
        {

        }

        public bool Equals(KeyTuple<T1, T2, T3, T4, T5, T6, T7, TRest> x, KeyTuple<T1, T2, T3, T4, T5, T6, T7, TRest> y)
        {

            var comparer1 = ZeroFormatterEqualityComparer<T1>.Default;
            var comparer2 = ZeroFormatterEqualityComparer<T2>.Default;
            var comparer3 = ZeroFormatterEqualityComparer<T3>.Default;
            var comparer4 = ZeroFormatterEqualityComparer<T4>.Default;
            var comparer5 = ZeroFormatterEqualityComparer<T5>.Default;
            var comparer6 = ZeroFormatterEqualityComparer<T6>.Default;
            var comparer7 = ZeroFormatterEqualityComparer<T7>.Default;
            var comparer8 = ZeroFormatterEqualityComparer<TRest>.Default;

            return comparer1.Equals(x.Item1, y.Item1) &&
                comparer2.Equals(x.Item2, y.Item2) &&
                comparer3.Equals(x.Item3, y.Item3) &&
                comparer4.Equals(x.Item4, y.Item4) &&
                comparer5.Equals(x.Item5, y.Item5) &&
                comparer6.Equals(x.Item6, y.Item6) &&
                comparer7.Equals(x.Item7, y.Item7) &&
                comparer8.Equals(x.Rest, y.Rest);
        }

        public int GetHashCode(KeyTuple<T1, T2, T3, T4, T5, T6, T7, TRest> obj)
        {
            if(obj.Item1 == null)
                throw new System.ArgumentNullException("Item1");
            if(obj.Item2 == null)
                throw new System.ArgumentNullException("Item2");
            if(obj.Item3 == null)
                throw new System.ArgumentNullException("Item3");
            if(obj.Item4 == null)
                throw new System.ArgumentNullException("Item4");
            if(obj.Item5 == null)
                throw new System.ArgumentNullException("Item5");
            if(obj.Item6 == null)
                throw new System.ArgumentNullException("Item6");
            if(obj.Item7 == null)
                throw new System.ArgumentNullException("Item7");
            if(obj.Rest == null)
                throw new System.ArgumentNullException("Rest");
                
            var comparer1 = ZeroFormatterEqualityComparer<T1>.Default;
            var comparer2 = ZeroFormatterEqualityComparer<T2>.Default;
            var comparer3 = ZeroFormatterEqualityComparer<T3>.Default;
            var comparer4 = ZeroFormatterEqualityComparer<T4>.Default;
            var comparer5 = ZeroFormatterEqualityComparer<T5>.Default;
            var comparer6 = ZeroFormatterEqualityComparer<T6>.Default;
            var comparer7 = ZeroFormatterEqualityComparer<T7>.Default;
            var comparer8 = ZeroFormatterEqualityComparer<TRest>.Default;

            int h0, h1, h2;
            h0 = comparer1.GetHashCode(obj.Item1);
            h0 = (h0 << 5) + h0 ^ comparer2.GetHashCode(obj.Item2);
            h1 = comparer3.GetHashCode(obj.Item3);
            h1 = (h1 << 5) + h1 ^ comparer4.GetHashCode(obj.Item4);
            h0 = (h0 << 5) + h0 ^ h1;
            h1 = comparer5.GetHashCode(obj.Item5);
            h1 = (h1 << 5) + h1 ^ comparer6.GetHashCode(obj.Item6);
            h2 = comparer7.GetHashCode(obj.Item7);
            h2 = (h2 << 5) + h2 ^ comparer8.GetHashCode(obj.Rest);
            h1 = (h1 << 5) + h1 ^ h2;
            h0 = (h0 << 5) + h0 ^ h1;
            return h0;
        }
    }
}