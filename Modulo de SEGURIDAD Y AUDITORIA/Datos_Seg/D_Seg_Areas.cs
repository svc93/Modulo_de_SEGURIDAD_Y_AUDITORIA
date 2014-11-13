using System;
using System.Collections.Generic;
using System.Linq;
using Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos_Seg.Dataset;
using Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos_Seg.Dataset.SISTEMADataSetTableAdapters;

namespace Modulo_de_SEGURIDAD_Y_AUDITORIA.Datos
{
    class D_Seg_Areas
    {
        public SISTEMADataSet.Cat_AreasDataTable tCatAreas()
        {
            Cat_AreasTableAdapter daCarAreas = new Cat_AreasTableAdapter();
            SISTEMADataSet.Cat_AreasDataTable dtCatAreas = new SISTEMADataSet.Cat_AreasDataTable();
            daCarAreas.Fill(dtCatAreas);
            return dtCatAreas;
        }

    }
}
