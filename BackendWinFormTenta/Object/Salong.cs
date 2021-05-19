namespace BackendWinFormTenta
{
    public class Salong
    {
        public virtual int ID { get; set; }
        public virtual int salongNum { get; set; }
        public virtual bool plats1 { get; set; }
        public virtual bool plats2 { get; set; }
        public virtual bool plats3 { get; set; }
        public virtual bool plats4 { get; set; }
        public virtual bool plats5 { get; set; }
        public virtual bool plats6 { get; set; }
        public virtual bool plats7 { get; set; }
        public virtual bool plats8 { get; set; }
        public virtual bool plats9 { get; set; }
        public virtual bool plats10 { get; set; }
        public virtual bool plats11{ get; set; }
        public virtual bool plats12 { get; set; }
        public virtual bool plats13 { get; set; }
        public virtual bool plats14 { get; set; }
        public virtual bool plats15 { get; set; }
        public virtual bool plats16 { get; set; }
        public virtual bool plats17 { get; set; }
        public virtual bool plats18 { get; set; }
        public virtual bool plats19 { get; set; }
        public virtual bool plats20 { get; set; }

        //public bool[] createArray()
        //{
        //    using(DbContextMovie dbContext = new DbContextMovie())
        //    {
        //        bool[] boolArray = new bool[20];
        //        boolArray[0] = plats1;
        //        boolArray[1] = plats2;
        //        boolArray[2] = plats3;
        //        boolArray[3] = plats4;
        //        boolArray[4] = plats5;
        //        boolArray[5] = plats6;
        //        boolArray[6] = plats7;
        //        boolArray[7] = plats8;
        //        boolArray[8] = plats9;
        //        boolArray[9] = plats10;
        //        boolArray[10] = plats11;
        //        boolArray[11] = plats12;
        //        boolArray[12] = plats13;
        //        boolArray[13] = plats14;
        //        boolArray[14] = plats15;
        //        boolArray[15] = plats16;
        //        boolArray[16] = plats17;
        //        boolArray[17] = plats18;
        //        boolArray[18] = plats19;
        //        boolArray[19] = plats20;
        //        dbContext.SaveChanges();
        //        return boolArray;
        //    }

        //}
        public void ArrayToPlats(bool[] boolArr)
        {
            plats1 = boolArr[0];
            plats2 = boolArr[1];
            plats3 = boolArr[2];
            plats4 = boolArr[3];
            plats5 = boolArr[4];
            plats6 = boolArr[5];
            plats7 = boolArr[6];
            plats8 = boolArr[7];
            plats9 = boolArr[8];
            plats10 = boolArr[9];
            plats11 = boolArr[10];
            plats12 = boolArr[11];
            plats13 = boolArr[12];
            plats14 = boolArr[13];
            plats15 = boolArr[14];
            plats16 = boolArr[15];
            plats17 = boolArr[16];
            plats18 = boolArr[17];
            plats19 = boolArr[18];
            plats20 = boolArr[19];
        }
        public Salong(int _salongnum)
        {
            salongNum = _salongnum;
        }
        public Salong()
        {

        }
    }
}