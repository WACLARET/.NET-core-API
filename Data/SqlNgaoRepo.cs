using System;
using System.Collections.Generic;
using System.Linq;
using NgaoApi.Data;
using NgaoApi.Models;

namespace ngaoApi.Data
{
    public class SqlNgaoRepo : INgaoRepo
    {
        private NgaoContext _context;

        public SqlNgaoRepo(NgaoContext context)
        {
            _context = context;
        }

        public void createngao(ngao cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.ngao.Add(cmd);
        }

        public IEnumerable<ngao> GetAllCommands()
        {
             return _context.ngao.ToList();
        }

        public ngao GetCommandById(int id)
        {
            return _context.ngao.FirstOrDefault(p => p.id == id);
        }

        public bool saveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void updatengao(ngao cmd)
        {
            //Do Nothing
        }
    }
}