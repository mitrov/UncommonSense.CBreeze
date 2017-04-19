﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Text;
using UncommonSense.CBreeze.Common;
using UncommonSense.CBreeze.Core;
using UncommonSense.CBreeze.IO;
using UncommonSense.CBreeze.Write;

namespace UncommonSense.CBreeze.Automation
{
    [Cmdlet(VerbsData.Export, "CBreezeApplication", DefaultParameterSetName = "ToTextWriter")]
    public class ExportCBreezeApplication : PSCmdlet
    {
        protected Application CachedObjects = new Application();

        public ExportCBreezeApplication()
        {
#if NAV2017
            DevClientPath = @"c:\Program Files (x86)\Microsoft Dynamics NAV\100\RoleTailored Client\finsql.exe";
#elif NAV2016
            DevClientPath = @"C:\Program Files (x86)\Microsoft Dynamics NAV\90\RoleTailored Client\finsql.exe";
#elif NAV2015
            DevClientPath = @"C:\Program Files (x86)\Microsoft Dynamics NAV\80\RoleTailored Client\finsql.exe";
#elif NAV2013R2
            DevClientPath = @"C:\Program Files (x86)\Microsoft Dynamics NAV\71\RoleTailored Client\finsql.exe";
#else
            DevClientPath = @"C:\Program Files (x86)\Microsoft Dynamics NAV\70\RoleTailored Client\finsql.exe";
#endif
            ServerName = ".";
            ImportAction = "Skip";
        }

        [Parameter(Mandatory = true, ValueFromPipeline = true, Position = 0)]
        [Alias("Application")]
        public PSObject[] InputObject
        {
            get;
            set;
        }

        [Parameter(Mandatory = true, ParameterSetName = "ToPath", Position = 1)]
        public string Path
        {
            get;
            set;
        }

        [Parameter(ParameterSetName = "ToTextWriter", Position = 1)]
        public TextWriter TextWriter
        {
            get;
            set;
        }

        [Parameter(Mandatory = true, ParameterSetName = "ToStream", Position = 1)]
        public Stream Stream
        {
            get;
            set;
        }

        [Parameter(ParameterSetName = "ToDatabase")]
        public string DevClientPath
        {
            get;
            set;
        }

        [Parameter(ParameterSetName = "ToDatabase")]
        public string ServerName
        {
            get;
            set;
        }

        [Parameter(Mandatory = true, ParameterSetName = "ToDatabase")]
        public string Database
        {
            get;
            set;
        }

        [Parameter(ParameterSetName = "ToDatabase")]
        [ValidateSet("Default", "Overwrite", "Skip")]
        public string ImportAction
        {
            get;
            set;
        }

        [Parameter(ParameterSetName = "ToDatabase")]
        public SwitchParameter AutoCompile
        {
            get;
            set;
        }

        protected override void BeginProcessing()
        {
            CachedObjects.Clear();
        }

        protected override void ProcessRecord()
        {
            foreach (var item in InputObject)
            {
                TypeSwitch.Do(
                    item.BaseObject,
                    TypeSwitch.Case<Application>(a => CachedObjects.Add(a.Objects)),
                    TypeSwitch.Case<Core.Object>(o => CachedObjects.Add(o))
                );
            }
        }

        protected override void EndProcessing()
        {
            switch (ParameterSetName)
            {
                case "ToPath":
                    CachedObjects.Write(Path);
                    break;

                case "ToTextWriter":
                    CachedObjects.Write(TextWriter ?? Console.Out);
                    break;

                case "ToStream":
                    CachedObjects.Write(Stream);
                    break;

                case "ToDatabase":
                    ApplicationImporter.Import(CachedObjects, DevClientPath, ServerName, Database);

                    if (AutoCompile)
                        ApplicationCompiler.Compile(CachedObjects, DevClientPath, ServerName, Database);
                    break;
            }
        }
    }
}