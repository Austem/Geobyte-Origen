﻿using geologycmcc.Controllers.DataBase;
using geologycmcc.Models.GeotecniaModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace geologycmcc.Controllers.Crud
{
    public class CRUDGeotecnia
    {

          
        TransaccionesGeotecnia tr;
        public RigeotReporte reporteGeotecnia(String HOLEID)
        {
            tr = new TransaccionesGeotecnia();
            RigeotReporte resultado = tr.dataReporteBANGEOT("SELECT TOP 100 PERCENT * FROM (SELECT * FROM (SELECT TOP 100 PERCENT * FROM ( SELECT [HOLELOCATION].[HOLEID], [HOLELOCATION].[PROJECTCODE], [HOLELOCATION].[HOLETYPE], [HOLEDETAILS].[RECARGO], [HOLECOMMENT].[RECCONTROL], [HOLECOMMENT].[RECEJECUCION], [HOLECOMMENT].[RECEMISOR], [HOLEDETAILS].[RECFECHA], [HOLEDETAILS].[RECFECHACIERRE], [HOLECOMMENT].[RECLUGAR], [HOLEDETAILS].[RECTURNO], [HOLEDETAILS].[RGN], [HOLEBIGCOMMENT].[RECANTECEDENTES], [HOLEBIGCOMMENT].[RECASUNTO], [HOLEBIGCOMMENT].[RECPATCHFOTO], [HOLEBIGCOMMENT].[RECPATCHFOTOCIERRE], [HOLEBIGCOMMENT].[RECEVALUACION], [HOLEBIGCOMMENT].[RECRECOMENDACION], [HOLELOCATION].[RL], [HOLELOCATION].[PROSPECT], [HOLELOCATION].[STARTDATE], [HOLELOCATION].[ENDDATE], [HOLEDETAILS].[RECFECHAPROGCIERRE], [HOLEDETAILS].[RECZONA], [HOLECOMMENT].[RECEJECUCIONCARGO], [HOLEBIGCOMMENT].[RECEVALUACION2], [HOLEBIGCOMMENT].[RECEVALUACION3], [HOLEBIGCOMMENT].[RECPATCHFOTO2], [HOLEBIGCOMMENT].[RECPATCHFOTO3], [HOLEDETAILS].[RECTIPO], [HOLEBIGCOMMENT].[RECPATCHACCIONES1] FROM [HOLELOCATION] INNER JOIN (SELECT * FROM [HOLELOCATION]) AS [CollarWSF] ON [CollarWSF].[HOLEID] = [HOLELOCATION].[HOLEID] AND [CollarWSF].[PROJECTCODE] = [HOLELOCATION].[PROJECTCODE] LEFT JOIN (SELECT [HOLEDETAILS].[HOLEID], [HOLEDETAILS].[PROJECTCODE], min(CASE when [HOLEDETAILS].[NAME] = 'RECARGO' then [HOLEDETAILS].[VALUE] ELSE NULL END) as [RECARGO], min(CASE when [HOLEDETAILS].[NAME] = 'RECFECHA' then [HOLEDETAILS].[VALUE] ELSE NULL END) as [RECFECHA], min(CASE when [HOLEDETAILS].[NAME] = 'RECFECHACIERRE' then [HOLEDETAILS].[VALUE] ELSE NULL END) as [RECFECHACIERRE], min(CASE when [HOLEDETAILS].[NAME] = 'RECTURNO' then [HOLEDETAILS].[VALUE] ELSE NULL END) as [RECTURNO], min(CASE when [HOLEDETAILS].[NAME] = 'RGN' then [HOLEDETAILS].[VALUE] ELSE NULL END) as [RGN], min(CASE when [HOLEDETAILS].[NAME] = 'RECFECHAPROGCIERRE' then [HOLEDETAILS].[VALUE] ELSE NULL END) as [RECFECHAPROGCIERRE], min(CASE when [HOLEDETAILS].[NAME] = 'RECZONA' then [HOLEDETAILS].[VALUE] ELSE NULL END) as [RECZONA], min(CASE when [HOLEDETAILS].[NAME] = 'RECTIPO' then[HOLEDETAILS].[VALUE] ELSE NULL END) as [RECTIPO] FROM[HOLEDETAILS] WHERE[HOLEDETAILS].[NAME] IN('RECARGO', 'RECFECHA', 'RECFECHACIERRE', 'RECTURNO', 'RGN', 'RECFECHAPROGCIERRE', 'RECZONA', 'RECTIPO') GROUP BY[HOLEDETAILS].[PROJECTCODE], [HOLEDETAILS].[HOLEID])[HOLEDETAILS] ON[HOLELOCATION].[PROJECTCODE] = [HOLEDETAILS].[PROJECTCODE]  AND[HOLELOCATION].[HOLEID] = [HOLEDETAILS].[HOLEID]"+
        "LEFT JOIN(SELECT[HOLECOMMENT].[HOLEID], [HOLECOMMENT].[PROJECTCODE], min(CASE when [HOLECOMMENT].[NAME] = 'RECCONTROL' then[HOLECOMMENT].[VALUE] ELSE NULL END) as [RECCONTROL], min(CASE when [HOLECOMMENT].[NAME] = 'RECEJECUCION' then[HOLECOMMENT].[VALUE] ELSE NULL END) as [RECEJECUCION], min(CASE when [HOLECOMMENT].[NAME] = 'RECEMISOR' then[HOLECOMMENT].[VALUE] ELSE NULL END) as [RECEMISOR], min(CASE when [HOLECOMMENT].[NAME] = 'RECLUGAR' then[HOLECOMMENT].[VALUE] ELSE NULL END) as [RECLUGAR], min(CASE when [HOLECOMMENT].[NAME] = 'RECEJECUCIONCARGO' then[HOLECOMMENT].[VALUE] ELSE NULL END) as [RECEJECUCIONCARGO]"+
        "FROM[HOLECOMMENT] WHERE[HOLECOMMENT].[NAME] IN('RECCONTROL', 'RECEJECUCION', 'RECEMISOR', 'RECLUGAR', 'RECEJECUCIONCARGO') GROUP BY[HOLECOMMENT].[PROJECTCODE], [HOLECOMMENT].[HOLEID])[HOLECOMMENT]"+
        "ON[HOLELOCATION].[PROJECTCODE] = [HOLECOMMENT].[PROJECTCODE]"+
        "AND[HOLELOCATION].[HOLEID] = [HOLECOMMENT].[HOLEID]"+
        "LEFT JOIN(SELECT[HOLEBIGCOMMENT].[HOLEID], [HOLEBIGCOMMENT].[PROJECTCODE], min(CASE when [HOLEBIGCOMMENT].[NAME] = 'RECANTECEDENTES' then[HOLEBIGCOMMENT].[VALUE] ELSE NULL END) as [RECANTECEDENTES], min(CASE when [HOLEBIGCOMMENT].[NAME] = 'RECASUNTO' then[HOLEBIGCOMMENT].[VALUE] ELSE NULL END) as [RECASUNTO], min(CASE when [HOLEBIGCOMMENT].[NAME] = 'RECPATCHFOTO' then[HOLEBIGCOMMENT].[VALUE] ELSE NULL END) as [RECPATCHFOTO], min(CASE when [HOLEBIGCOMMENT].[NAME] = 'RECPATCHFOTOCIERRE' then[HOLEBIGCOMMENT].[VALUE] ELSE NULL END) as [RECPATCHFOTOCIERRE], min(CASE when [HOLEBIGCOMMENT].[NAME] = 'RECEVALUACION' then[HOLEBIGCOMMENT].[VALUE] ELSE NULL END) as [RECEVALUACION],"+
 "min(CASE when [HOLEBIGCOMMENT].[NAME] = 'RECRECOMENDACION' then[HOLEBIGCOMMENT].[VALUE] ELSE NULL END) as [RECRECOMENDACION], min(CASE when [HOLEBIGCOMMENT].[NAME] = 'RECEVALUACION2' then[HOLEBIGCOMMENT].[VALUE] ELSE NULL END) as [RECEVALUACION2], min(CASE when [HOLEBIGCOMMENT].[NAME] = 'RECEVALUACION3' then[HOLEBIGCOMMENT].[VALUE] ELSE NULL END) as [RECEVALUACION3], min(CASE when [HOLEBIGCOMMENT].[NAME] = 'RECPATCHFOTO2' then[HOLEBIGCOMMENT].[VALUE] ELSE NULL END) as [RECPATCHFOTO2], min(CASE when [HOLEBIGCOMMENT].[NAME] = 'RECPATCHFOTO3' then[HOLEBIGCOMMENT].[VALUE] ELSE NULL END) as [RECPATCHFOTO3], min(CASE when [HOLEBIGCOMMENT].[NAME] = 'RECPATCHACCIONES1' then[HOLEBIGCOMMENT].[VALUE] ELSE NULL END) as [RECPATCHACCIONES1]"+
        "FROM[HOLEBIGCOMMENT] GROUP BY[HOLEBIGCOMMENT].[PROJECTCODE], [HOLEBIGCOMMENT].[HOLEID])[HOLEBIGCOMMENT]"+
        "ON[HOLELOCATION].[PROJECTCODE] = [HOLEBIGCOMMENT].[PROJECTCODE]"+
        "AND[HOLELOCATION].[HOLEID] = [HOLEBIGCOMMENT].[HOLEID]) [ACQTMP]  ) AS[TMPVIEW4]) [TMPSQLSHEETVIEW]"+


"WHERE(([TMPSQLSHEETVIEW].[HOLEID] = '"+HOLEID+"'))");

            return resultado;
        }

    }
}