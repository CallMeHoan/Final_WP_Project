using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_WP_Project
{
    class Global
    {
       public static string GlobalId { get; private set; }
        public static int Mana { get; private set; }
        public static int Recep { get; private set; }
        public static int Labor { get; private set; }
        public static string Day { get; private set; }
        public static string Hour { get; private set; }
        public static string Minute { get; private set; }
        public static float LateSalary { get; private set; }
        public static float AbsentSalary { get; private set; }
        public static string[,] Schedule { get; private set; }
        public static bool isManager { get; private set; }
        public static string s1 { get; private set; }
        public static string s2 { get; private set; }
        public static string s3 { get; private set; }
        public static string s4 { get; private set; }
        public static string s5 { get; private set; }
        public static string s6 { get; private set; }
        public static string RoomID { get; private set; }
        public static void SetID(string userid)
        {
            GlobalId = userid;
        }
        public static void s1a(string userid)
        {
            s1 = userid;
        }
        public static void s2a(string userid)
        {
            s2 = userid;
        }
        public static void s3a(string userid)
        {
            s3 = userid;
        }
        public static void s4a(string userid)
        {
            s4 = userid;
        }
        public static void s5a(string userid)
        {
            s5 = userid;
        }
        public static void s6a(string userid)
        {
            s6 = userid;
        }
        public static void GetBoolManager(bool ismana)
        {
            isManager = ismana;
        }
        public static void SetLateSalary(float lateSalaryy)
        {
            LateSalary = lateSalaryy;

        }
        public static void SetAbsentSalary(float AbsentSalaryy)
        {
            AbsentSalary = AbsentSalaryy;
        }
        public static void GetHour(string hourr)
        {
            Hour = hourr;
        }
        public static void GetMinute(string minutee)
        {
            Minute = minutee;
        }
        public static void GetDay(string dayy)
        {
            Day = dayy; 
        }
        public static void SetMana(int Manaa)
        {
            Mana = Manaa;
        }
        public static void SetRecep(int Recepp)
        {
            Recep = Recepp;
        }
        public static void SetLabor(int Laborr)
        {
            Labor = Laborr;
        }
        public static void SetSchedule(string[,] Schedulee)
        {
            Schedule = Schedulee;
        }
        public static void SetRoomID( string roomid)
        {
            RoomID = roomid;
        }
    }
}
