using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace rabinSoft
{
    public static class GV
    {
        static string hitSaler;
        public static string GlobalSaler
        {
            get { return hitSaler; }
            set { hitSaler = value; }
        }

        static int hitAdd;
        public static int GlobalAdd
        {
            get { return hitAdd; }
            set { hitAdd = value; }
        }

        static double hitTotal;
        public static double GlobalTotal
        {
            get { return hitTotal; }
            set { hitTotal = value; }
        }

        static double hitUnit;
        public static double GlobalUnit
        {
            get { return hitUnit; }
            set { hitUnit = value; }
        }

        static string hitType;
        public static string GlobalType
        {
            get { return hitType; }
            set { hitType = value; }
        }

        static double hitTk;
        public static double GlobalTk
        {
            get { return hitTk; }
            set { hitTk = value; }
        }

        static double hitLt;
        public static double GlobalLt
        {
            get { return hitLt; }
            set { hitLt = value; }
        }

        static Boolean hitDisplay;
        public static Boolean GlobalDisplay
        {
            get { return hitDisplay; }
            set { hitDisplay = value; }
        }

        static string hitItem;
        public static string GlobalItem
        {
            get { return hitItem; }
            set { hitItem = value; }
        }

        static double hitStock;
        public static double GlobalStock
        {
            get { return hitStock; }
            set { hitStock = value; }
        }
    }
}
