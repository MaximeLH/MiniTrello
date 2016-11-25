using MiniTrello.Data;
using MiniTrello.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;

namespace MiniTrello.Data
{
    public class MinitrelloInitializer : DropCreateDatabaseIfModelChanges<MinitrelloDB>
    {
        public object HttpRuntime { get; private set; }

        //private byte[] GetFileBytes(string path)
        //{
        //    FileStream fileOnDisk = new FileStream(HttpRuntime.AppDomainAppPath + path, FileMode.Open);
        //    byte[] fileBytes;
        //    using (BinaryReader br = new BinaryReader(fileOnDisk))
        //    {
        //        fileBytes = br.ReadBytes((int)fileOnDisk.Length);
        //    }
        //    return fileBytes;
        //}

        protected override void Seed(MinitrelloDB ctx)
        {
            base.Seed(ctx);
          
            }



        }
    }
