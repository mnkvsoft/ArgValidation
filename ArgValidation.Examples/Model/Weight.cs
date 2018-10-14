//using System;
//
//namespace ArgValidation.Examples
//{
//    internal struct Weight : IComparable<Weight>
//    {
//        private double _kg;
//
//        public Weight(double kg)
//        {
//            _kg = kg;
//        }
//
//        public static Weight Kg(double kg)
//        {
//            Arg.Validate(() => kg).MoreOrEqualThan(0);
//                
//            return new Weight(kg);
//        }
//            
//        public static Weight Tn(double tn)
//        {
//            return new Weight(kg: tn * 1000);
//        }
//
//        public int CompareTo(Weight other)
//        {
//            return _kg.CompareTo(other._kg);
//        }
//
//        public override string ToString()
//        {
//            return _kg < 1000 ? _kg + " Kg" : _kg / 1000 + " Tn";
//        }
//    }
//}