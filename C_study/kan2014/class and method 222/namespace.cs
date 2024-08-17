using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
   * 목표: 이름공간(name space) 이해
   * 작성일: 2024/8/17
 */

/*
 * 2. 네임스펭이스 방법
 *  namespace 이름공간 이름 {     } 범위 표현 공간
*/
namespace 북한
{
    class 치킨
    {
       public   int ea;
    }
}
namespace 남한 
{
    class 치킨
    {
        public  int ea;
    }
}

namespace class_and_method_222
{
    internal class @namespace
    {
        public void show()
        {
            // 1.이름중복 안돼는 예
            //int w = 1;
            //int w = 41;
            북한.치킨 ea = new 북한.치킨();
            남한.치킨 rea = new 남한.치킨();
        }
    }
}
