using NLog;
using PracaInzynierskaAPI.DataBase.UnitOfWork;
using PracaInzynierskaAPI.Entities.NLog;
using System;
using System.Collections.Generic;

namespace PracaInzynierska.Application.Services.NLog
{
    public class NLogService: INLogService
    {
        private readonly IUnitOfWork _unitOfWork;
        private ILogger _logger;

        public NLogService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _logger = LogManager.GetCurrentClassLogger();
        }

        public IEnumerable<NLogDbModel> GetAllNLogs()
        {
            var result = default(IEnumerable<NLogDbModel>);
            try
            {
                result = _unitOfWork.GetNLogRepository.GetAll();
            }
            catch (Exception err)
            {
                _logger.Error(err, "NLogService.GetAllNLogs");
                throw;
            }
            return result;
        }

        public IEnumerable<NLogDbModel> GetNLogsByDateTimeRange(DateTime dateTimeFrom, DateTime dateTimeTo)
        {
            var result = default(IEnumerable<NLogDbModel>);
            try
            {
                result = _unitOfWork.GetNLogRepository.GetByDateTimeRange(dateTimeFrom, dateTimeTo);
            }
            catch (Exception err)
            {
                _logger.Error(err, "NLogService.GetAllNLogs");
                throw;
            }
            return result;
        }
    }
}
