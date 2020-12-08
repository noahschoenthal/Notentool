﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Notentool.Models.Entities;

namespace Notentool.Services
{
    /// <summary>
    /// Interface für den Datenbankzugriff der Module
    /// Autoren: Gion Rubitschung und Noah Siroh Schönthal
    /// </summary>
    public interface IModulsService
    {
        /// <summary>
        /// Ruft alle Module aus der Datenbank für ein Semester ab
        /// </summary>
        /// <param name="semesterId">Die id des Semesters in der die Module abgerufen werden sollen</param>
        /// <returns>Liste der Module als <c>IEnumerable</c></returns>
        IEnumerable<Modul> GetAllModuls(int semesterId);

        /// <summary>
        /// Ruft ein Modul nach seiner Id in der Datenbank ab
        /// </summary>
        /// <param name="id">Die id des Moduls</param>
        /// <returns>Modul als <c>Modul</c></returns>
        Task<Modul> GetModulByIdAsync(int id);

        /// <summary>
        /// Erstellt ein neues Modul in der Datenbank
        /// </summary>
        /// <param name="modul">Das Modul, welches in der Datenbank erstellt werden soll</param>
        /// <param name="semester">Das Semester in dem das Modul erstellt werden soll</param>
        Task CreateModulAsync(Modul modul, Semester semester);

        /// <summary>
        /// Aktualisiert ein Modul in der Datenbank
        /// </summary>
        /// <param name="modul">Das Modul, welches in der Datenbank aktualisiert werden soll</param>
        /// <param name="semester">Das Semester in dem das Modul aktualisiert werden soll. Wird mitgeben um zu überprüfen ob das Modul ein Semester hinterlegt hat</param>
        Task UpdateModulAsync(Modul modul, Semester semester);

        /// <summary>
        /// Löscht ein Modul in der Datenbank
        /// </summary>
        /// <param name="id">Die id des Moduls, welches gelöscht werden soll</param>
        Task DeleteModulAsync(int id);

        /// <summary>
        /// Überprüft ob ein Modul in der Datenbank existiert
        /// </summary>
        /// <param name="id">Die id des Moduls</param>
        /// <returns>Existenz des Moduls als <c>bool</c></returns>
        bool ModulExists(int id);
    }
}