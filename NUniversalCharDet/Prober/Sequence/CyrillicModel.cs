﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mozilla.NUniversalCharDet.Prober.Sequence
{
    public class CyrillicModel : SequenceModel
    {
        ////////////////////////////////////////////////////////////////
        // constants
        ////////////////////////////////////////////////////////////////
        public static float TYPICAL_POSITIVE_RATIO = 0.976601f;


        ////////////////////////////////////////////////////////////////
        // methods
        ////////////////////////////////////////////////////////////////
        public CyrillicModel(short[] charToOrderMap, string name)
            : base(charToOrderMap, russianLangModel, TYPICAL_POSITIVE_RATIO, false, name)
        {

        }


        ////////////////////////////////////////////////////////////////
        // constants continued
        ////////////////////////////////////////////////////////////////
        private static byte[] russianLangModel = new byte[] {
        0,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,1,1,3,3,3,3,1,3,3,3,2,3,2,3,3,
        3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,0,3,2,2,2,2,2,0,0,2,
        3,3,3,2,3,3,3,3,3,3,3,3,3,3,2,3,3,0,0,3,3,3,3,3,3,3,3,3,2,3,2,0,
        0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
        3,3,3,2,2,3,3,3,3,3,3,3,3,3,2,3,3,0,0,3,3,3,3,3,3,3,3,2,3,3,1,0,
        0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
        3,2,3,2,3,3,3,3,3,3,3,3,3,3,3,3,3,0,0,3,3,3,3,3,3,3,3,3,3,3,2,1,
        0,0,0,0,0,0,0,2,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
        3,3,3,3,3,3,3,3,3,3,3,3,3,3,2,3,3,0,0,3,3,3,3,3,3,3,3,3,3,3,2,1,
        0,0,0,0,0,1,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
        3,3,3,3,3,3,3,3,2,2,2,3,1,3,3,1,3,3,3,3,2,2,3,0,2,2,2,3,3,2,1,0,
        0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,
        3,3,3,3,3,3,2,3,3,3,3,3,2,2,3,2,3,3,3,2,1,2,2,0,1,2,2,2,2,2,2,0,
        0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0,0,
        3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,3,2,2,2,3,0,2,2,3,3,2,1,2,0,
        0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0,0,0,0,1,0,0,2,0,0,0,0,0,0,0,0,0,
        3,3,3,3,3,3,2,3,3,1,2,3,2,2,3,2,3,3,3,3,2,2,3,0,3,2,2,3,1,1,1,0,
        0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
        3,3,3,3,3,3,3,3,2,2,3,3,3,3,3,2,3,3,3,3,2,2,2,0,3,3,3,2,2,2,2,0,
        0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
        3,3,3,3,3,3,3,3,3,3,2,3,2,3,3,3,3,3,3,2,3,2,2,0,1,3,2,1,2,2,1,0,
        0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0,0,
        3,3,3,3,3,3,3,3,3,3,3,2,1,1,3,0,1,1,1,1,2,1,1,0,2,2,2,1,2,0,1,0,
        0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
        3,3,3,3,3,3,2,3,3,2,2,2,2,1,3,2,3,2,3,2,1,2,2,0,1,1,2,1,2,1,2,0,
        0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
        3,3,3,3,3,3,3,3,3,3,3,3,2,2,3,2,3,3,3,2,2,2,2,0,2,2,2,2,3,1,1,0,
        0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0,0,
        3,2,3,2,2,3,3,3,3,3,3,3,3,3,1,3,2,0,0,3,3,3,3,2,3,3,3,3,2,3,2,0,
        0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
        2,3,3,3,3,3,2,2,3,3,0,2,1,0,3,2,3,2,3,0,0,1,2,0,0,1,0,1,2,1,1,0,
        0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
        3,0,3,0,2,3,3,3,3,2,3,3,3,3,1,2,2,0,0,2,3,2,2,2,3,2,3,2,2,3,0,0,
        0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
        3,2,3,0,2,3,2,3,0,1,2,3,3,2,0,2,3,0,0,2,3,2,2,0,1,3,1,3,2,2,1,0,
        0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
        3,1,3,0,2,3,3,3,3,3,3,3,3,2,1,3,2,0,0,2,2,3,3,3,2,3,3,0,2,2,0,0,
        0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
        3,3,3,3,3,3,2,2,3,3,2,2,2,3,3,0,0,1,1,1,1,1,2,0,0,1,1,1,1,0,1,0,
        0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
        3,3,3,3,3,3,2,2,3,3,3,3,3,3,3,0,3,2,3,3,2,3,2,0,2,1,0,1,1,0,1,0,
        0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0,0,
        3,3,3,3,3,3,2,3,3,3,2,2,2,2,3,1,3,2,3,1,1,2,1,0,2,2,2,2,1,3,1,0,
        0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0,0,
        2,2,3,3,3,3,3,1,2,2,1,3,1,0,3,0,0,3,0,0,0,1,1,0,1,2,1,0,0,0,0,0,
        0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
        3,2,2,1,1,3,3,3,2,2,1,2,2,3,1,1,2,0,0,2,2,1,3,0,0,2,1,1,2,1,1,0,
        0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
        3,2,3,3,3,3,1,2,2,2,1,2,1,3,3,1,1,2,1,2,1,2,2,0,2,0,0,1,1,0,1,0,
        0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
        2,3,3,3,3,3,2,1,3,2,2,3,2,0,3,2,0,3,0,1,0,1,1,0,0,1,1,1,1,0,1,0,
        0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
        3,3,2,3,3,3,2,2,2,3,3,1,2,1,2,1,0,1,0,1,1,0,1,0,0,2,1,1,1,0,1,0,
        0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,
        3,1,1,2,1,2,3,3,2,2,1,2,2,3,0,2,1,0,0,2,2,3,2,1,2,2,2,2,2,3,1,0,
        0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
        3,3,3,3,3,1,1,0,1,1,2,2,1,1,3,0,0,1,3,1,1,1,0,0,0,1,0,1,1,0,0,0,
        0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
        2,1,3,3,3,2,0,0,0,2,1,0,1,0,2,0,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
        0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
        2,0,1,0,0,2,3,2,2,2,1,2,2,2,1,2,1,0,0,1,1,1,0,2,0,1,1,1,0,0,1,1,
        1,0,0,0,0,0,1,2,0,0,0,0,0,1,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,
        2,3,3,3,3,0,0,0,0,1,0,0,0,0,3,0,1,2,1,0,0,0,0,0,0,0,1,1,0,0,1,1,
        1,0,1,0,1,2,0,0,1,1,2,1,0,1,1,1,1,0,1,1,1,1,0,1,0,0,1,0,0,1,1,0,
        2,2,3,2,2,2,3,1,2,2,2,2,2,2,2,2,1,1,1,1,1,1,1,0,1,0,1,1,1,0,2,1,
        1,1,1,1,1,1,1,1,2,1,1,1,1,1,1,1,1,1,1,0,1,0,1,1,0,1,1,1,0,1,1,0,
        3,3,3,2,2,2,2,3,2,2,1,1,2,2,2,2,1,1,3,1,2,1,2,0,0,1,1,0,1,0,2,1,
        1,1,1,1,1,2,1,0,1,1,1,1,0,1,0,0,1,1,0,0,1,0,1,0,0,1,0,0,0,1,1,0,
        2,0,0,1,0,3,2,2,2,2,1,2,1,2,1,2,0,0,0,2,1,2,2,1,1,2,2,0,1,1,0,2,
        1,1,1,1,1,0,1,1,1,2,1,1,1,2,1,0,1,2,1,1,1,1,0,1,1,1,0,0,1,0,0,1,
        1,3,2,2,2,1,1,1,2,3,0,0,0,0,2,0,2,2,1,0,0,0,0,0,0,1,0,0,0,0,1,1,
        1,0,1,1,0,1,0,1,1,0,1,1,0,2,0,0,1,1,0,0,1,0,0,0,0,0,0,0,0,1,1,0,
        2,3,2,3,2,1,2,2,2,2,1,0,0,0,2,0,0,1,1,0,0,0,0,0,0,0,1,1,0,0,2,1,
        1,1,2,1,0,2,0,0,1,0,1,0,0,1,0,0,1,1,0,1,1,0,0,0,0,0,1,0,0,0,0,0,
        3,0,0,1,0,2,2,2,3,2,2,2,2,2,2,2,0,0,0,2,1,2,1,1,1,2,2,0,0,0,1,2,
        1,1,1,1,1,0,1,2,1,1,1,1,1,1,1,0,1,1,1,1,1,1,0,1,1,1,1,1,1,0,0,1,
        2,3,2,3,3,2,0,1,1,1,0,0,1,0,2,0,1,1,3,1,0,0,0,0,0,0,0,1,0,0,2,1,
        1,1,1,1,1,1,1,0,1,0,1,1,1,1,0,1,1,1,0,0,1,1,0,1,0,0,0,0,0,0,1,0,
        2,3,3,3,3,1,2,2,2,2,0,1,1,0,2,1,1,1,2,1,0,1,1,0,0,1,0,1,0,0,2,0,
        0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
        2,3,3,3,2,0,0,1,1,2,2,1,0,0,2,0,1,1,3,0,0,1,0,0,0,0,0,1,0,1,2,1,
        1,1,2,0,1,1,1,0,1,0,1,1,0,1,0,1,1,1,1,0,1,0,0,0,0,0,0,1,0,1,1,0,
        1,3,2,3,2,1,0,0,2,2,2,0,1,0,2,0,1,1,1,0,1,0,0,0,3,0,1,1,0,0,2,1,
        1,1,1,0,1,1,0,0,0,0,1,1,0,1,0,0,2,1,1,0,1,0,0,0,1,0,1,0,0,1,1,0,
        3,1,2,1,1,2,2,2,2,2,2,1,2,2,1,1,0,0,0,2,2,2,0,0,0,1,2,1,0,1,0,1,
        2,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0,2,1,1,1,0,1,0,1,1,0,1,1,1,0,0,1,
        3,0,0,0,0,2,0,1,1,1,1,1,1,1,0,1,0,0,0,1,1,1,0,1,0,1,1,0,0,1,0,1,
        1,1,0,0,1,0,0,0,1,0,1,1,0,0,1,0,1,0,1,0,0,0,0,1,0,0,0,1,0,0,0,1,
        1,3,3,2,2,0,0,0,2,2,0,0,0,1,2,0,1,1,2,0,0,0,0,0,0,0,0,1,0,0,2,1,
        0,1,1,0,0,1,1,0,0,0,1,1,0,1,1,0,1,1,0,0,1,0,0,0,0,0,0,0,0,0,1,0,
        2,3,2,3,2,0,0,0,0,1,1,0,0,0,2,0,2,0,2,0,0,0,0,0,1,0,0,1,0,0,1,1,
        1,1,2,0,1,2,1,0,1,1,2,1,1,1,1,1,2,1,1,0,1,0,0,1,1,1,1,1,0,1,1,0,
        1,3,2,2,2,1,0,0,2,2,1,0,1,2,2,0,0,1,0,0,0,0,0,0,0,0,0,1,0,0,1,1,
        0,0,1,1,0,1,1,0,0,1,1,0,1,1,0,0,1,1,0,0,1,0,0,0,0,0,0,0,0,0,0,0,
        1,0,0,1,0,2,3,1,2,2,2,2,2,2,1,1,0,0,0,1,0,1,0,2,1,1,1,0,0,0,0,1,
        1,1,0,1,1,0,1,1,1,1,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0,1,0,0,0,
        2,0,2,0,0,1,0,3,2,1,2,1,2,2,0,1,0,0,0,2,1,0,0,2,1,1,1,1,0,2,0,2,
        2,1,1,1,1,1,1,1,1,1,1,1,1,2,1,0,1,1,1,1,0,0,0,1,1,1,1,0,1,0,0,1,
        1,2,2,2,2,1,0,0,1,0,0,0,0,0,2,0,1,1,1,1,0,0,0,0,1,0,1,2,0,0,2,0,
        1,0,1,1,1,2,1,0,1,0,1,1,0,0,1,0,1,1,1,0,1,0,0,0,1,0,0,1,0,1,1,0,
        2,1,2,2,2,0,3,0,1,1,0,0,0,0,2,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        0,0,0,1,1,1,0,0,1,0,1,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,1,0,0,
        1,2,2,3,2,2,0,0,1,1,2,0,1,2,1,0,1,0,1,0,0,1,0,0,0,0,0,0,0,0,0,1,
        0,1,1,0,0,1,1,0,0,1,1,0,0,1,1,0,1,1,0,0,1,0,0,0,0,0,0,0,0,1,1,0,
        2,2,1,1,2,1,2,2,2,2,2,1,2,2,0,1,0,0,0,1,2,2,2,1,2,1,1,1,1,1,2,1,
        1,1,1,1,1,1,1,1,1,1,0,0,1,1,1,0,1,1,1,0,0,0,0,1,1,1,0,1,1,0,0,1,
        1,2,2,2,2,0,1,0,2,2,0,0,0,0,2,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,2,0,
        0,0,1,0,0,1,0,0,0,0,1,0,1,1,0,0,1,1,0,0,1,0,0,0,0,0,0,0,0,0,0,0,
        0,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,
        0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
        1,2,2,2,2,0,0,0,2,2,2,0,1,0,1,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,
        0,1,1,0,0,1,1,0,0,0,1,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
        1,2,2,2,2,0,0,0,0,1,0,0,1,1,2,0,0,0,0,1,0,1,0,0,1,0,0,2,0,0,0,1,
        0,0,1,0,0,1,0,0,0,1,1,0,0,0,0,0,1,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,
        1,2,2,2,1,1,2,0,2,1,1,1,1,0,2,2,0,0,0,0,0,0,0,0,0,1,1,0,0,0,1,1,
        0,0,1,0,1,1,0,0,0,0,1,0,0,0,0,0,1,1,0,0,1,0,0,0,0,0,0,0,0,0,0,0,
        1,0,2,1,2,0,0,0,0,0,1,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,1,0,0,0,0,
        0,0,1,0,1,1,0,0,0,0,1,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,1,0,
        1,0,0,0,0,2,0,1,2,1,0,1,1,1,0,1,0,0,0,1,0,1,0,0,1,0,1,0,0,0,0,1,
        0,0,0,0,0,1,0,0,1,1,0,0,1,1,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,1,
        2,2,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,0,0,0,1,0,0,0,1,1,0,0,0,0,0,0,0,1,0,0,0,0,0,1,0,0,1,0,0,0,0,0,
        2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,1,1,0,1,0,1,0,0,1,1,1,1,0,0,0,1,0,0,0,0,1,0,0,0,1,0,1,0,0,0,0,
        1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,
        1,1,0,1,1,0,1,0,1,0,0,0,0,1,1,0,1,1,0,0,0,0,0,1,0,1,1,0,1,0,0,0,
        0,1,1,1,1,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,
        0,0,0,0,0,1,0,0,0,0,1,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,
    };
    }
}
