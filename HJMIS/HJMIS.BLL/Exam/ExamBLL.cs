using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Dos.ORM;
using Dos.Common;
using Dos.ORM.Common;
using Dos.Model;

namespace HJMIS.BLL.Exam
{
    public class ExamBLL
    {

        public BaseResult GetExamList()
        {
            List<tb_Training> list = DbSession.Default.From<tb_Training>().Where(a => a.TRSex == "男").ToList();

            return new BaseResult(true, list, "", 10);
        }
    }
}
