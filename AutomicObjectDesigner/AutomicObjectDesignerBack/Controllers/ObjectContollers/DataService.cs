﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutomicObjectDesigner.Models.Objects;

namespace AutomicObjectDesignerBack.Controllers.ObjectContollers
{
    public class DataService
    {
        public static DataService Current { get; } = new DataService();
        public List<SapSimple> SapSimple { get; set; }

        public DataService()
        {
            SapSimple = new List<SapSimple>()
            {
                new SapSimple
                {
                    SapReport = "QSW.102#ZZZ#PAYMENT#MYREP_01$VAR_101.JOBS",
                    SapJobName = "NAME1_IN_SAP",
                    SapVariant = "SAP.JOB",
                    Agent = "Agent1",
                    Active = true,
                    DeleteSapJob = false,
                    Folder = "Document",
                    Id = 5,
                    Login = "Agent1",
                    Queue = "QSW102_A.QUEUE",
                    MaxParallelTasks = 5,
                    OwnerId = 4,
                    Process = "Process",
                    PorcessName = "R3_ACTIVATE_REPORT REPORT=&SAP_REPORT#,VARIANT=&SAP_VARIANT#",
                    PreProcess = ":INC XXX.XXX#ZZZ#SAP_PRE#GENERAL.JOBI",
                    PostProcess = ":INC XXX.XXX#ZZZ#SAP_POST#GENERAL.JOBI",

                },
                new SapSimple
                {
                    
                    SapReport = "QSW.102#ZZZ#PAYMENT#MYREP_01$VAR_101.JOBS",
                    SapJobName = "NAME1_IN_SAP", 
                    SapVariant = "SAP.JOB",
                    Agent = "Agent2",
                    Active = true,
                    DeleteSapJob = false,
                    Folder = "Document",
                    Id = 6,
                    Login = "Agent2",
                    Queue = "QSW102_A.QUEUE",
                    MaxParallelTasks = 6,
                    OwnerId = 5,
                    Process = "Process",
                    PorcessName = "R3_ACTIVATE_REPORT REPORT=&SAP_REPORT#,VARIANT=&SAP_VARIANT#",
                    PreProcess = ":INC XXX.XXX#ZZZ#SAP_PRE#GENERAL.JOBI",
                    PostProcess = ":INC XXX.XXX#ZZZ#SAP_POST#GENERAL.JOBI",

                }
            };
        }
    }
}