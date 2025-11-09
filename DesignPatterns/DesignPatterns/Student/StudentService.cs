using DesignPatterns.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Student
{
    public class StudentService : IStudentService
    {
        private Logger _logger;

        public StudentService(Logger? log) => _logger = log;
        public void Add()
        {
            Console.WriteLine("Öğrenci kaydedildi.");
            _logger.Log("Kullanıcı sisteme öğrenci kayıt edildi.");
        }

        public void Delete()
        {
            Console.WriteLine("Öğrenci kaydı silindi.");
            _logger.Log("Kullanıcı sistemden öğrenciyi sildi.");
        }

        public void List()
        {
            Console.WriteLine("Öğrenci listeye eklendi.");
            _logger.Log("Kullanıcı sisteme öğrenci listeye ekledi.");
        }

        public void Update()
        {
            Console.WriteLine("Öğrenci kaydı güncellendi.");
            _logger.Log("Kullanıcı sisteme öğrenci kayıt güncellendi.");
        }
    }
}
