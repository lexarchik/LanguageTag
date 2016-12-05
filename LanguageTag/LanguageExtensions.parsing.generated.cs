using System;
using System.Globalization;

namespace AbbyyLS.Globalization.Bcp47
{
	public static partial class LanguageTagExtensions
	{
		public static Language? TryParseFromLanguage(this string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return tryParseFromLanguage_a(text, ref offset);
					case 'b': return tryParseFromLanguage_b(text, ref offset);
					case 'c': return tryParseFromLanguage_c(text, ref offset);
					case 'd': return tryParseFromLanguage_d(text, ref offset);
					case 'e': return tryParseFromLanguage_e(text, ref offset);
					case 'f': return tryParseFromLanguage_f(text, ref offset);
					case 'g': return tryParseFromLanguage_g(text, ref offset);
					case 'h': return tryParseFromLanguage_h(text, ref offset);
					case 'i': return tryParseFromLanguage_i(text, ref offset);
					case 'j': return tryParseFromLanguage_j(text, ref offset);
					case 'k': return tryParseFromLanguage_k(text, ref offset);
					case 'l': return tryParseFromLanguage_l(text, ref offset);
					case 'm': return tryParseFromLanguage_m(text, ref offset);
					case 'n': return tryParseFromLanguage_n(text, ref offset);
					case 'o': return tryParseFromLanguage_o(text, ref offset);
					case 'p': return tryParseFromLanguage_p(text, ref offset);
					case 'q': return tryParseFromLanguage_q(text, ref offset);
					case 'r': return tryParseFromLanguage_r(text, ref offset);
					case 's': return tryParseFromLanguage_s(text, ref offset);
					case 't': return tryParseFromLanguage_t(text, ref offset);
					case 'u': return tryParseFromLanguage_u(text, ref offset);
					case 'v': return tryParseFromLanguage_v(text, ref offset);
					case 'w': return tryParseFromLanguage_w(text, ref offset);
					case 'x': return tryParseFromLanguage_x(text, ref offset);
					case 'y': return tryParseFromLanguage_y(text, ref offset);
					case 'z': return tryParseFromLanguage_z(text, ref offset);
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_a(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return tryParseFromLanguage_aa(text, ref offset);
					case 'b': return tryParseFromLanguage_ab(text, ref offset);
					case 'e': return tryParseFromLanguage_ae(text, ref offset);
					case 'f': return tryParseFromLanguage_af(text, ref offset);
					case 'k': return tryParseFromLanguage_ak(text, ref offset);
					case 'm': return tryParseFromLanguage_am(text, ref offset);
					case 'n': return tryParseFromLanguage_an(text, ref offset);
					case 'r': return tryParseFromLanguage_ar(text, ref offset);
					case 's': return tryParseFromLanguage_as(text, ref offset);
					case 'v': return tryParseFromLanguage_av(text, ref offset);
					case 'y': return tryParseFromLanguage_ay(text, ref offset);
					case 'z': return tryParseFromLanguage_az(text, ref offset);
					case 'c': return tryParseFromLanguage_ac(text, ref offset);
					case 'd': return tryParseFromLanguage_ad(text, ref offset);
					case 'g': return tryParseFromLanguage_ag(text, ref offset);
					case 'h': return tryParseFromLanguage_ah(text, ref offset);
					case 'i': return tryParseFromLanguage_ai(text, ref offset);
					case 'j': return tryParseFromLanguage_aj(text, ref offset);
					case 'l': return tryParseFromLanguage_al(text, ref offset);
					case 'o': return tryParseFromLanguage_ao(text, ref offset);
					case 'p': return tryParseFromLanguage_ap(text, ref offset);
					case 'q': return tryParseFromLanguage_aq(text, ref offset);
					case 't': return tryParseFromLanguage_at(text, ref offset);
					case 'u': return tryParseFromLanguage_au(text, ref offset);
					case 'w': return tryParseFromLanguage_aw(text, ref offset);
					case 'x': return tryParseFromLanguage_ax(text, ref offset);
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_aa(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.AAA;
					case 'b': return Language.AAB;
					case 'c': return Language.AAC;
					case 'd': return Language.AAD;
					case 'e': return Language.AAE;
					case 'f': return Language.AAF;
					case 'g': return Language.AAG;
					case 'h': return Language.AAH;
					case 'i': return Language.AAI;
					case 'k': return Language.AAK;
					case 'l': return Language.AAL;
					case 'm': return Language.AAS;
					case 'n': return Language.AAN;
					case 'o': return Language.AAO;
					case 'p': return Language.AAP;
					case 'q': return Language.AAQ;
					case 's': return Language.AAS;
					case 't': return Language.AAT;
					case 'u': return Language.AAU;
					case 'v': return Language.AAV;
					case 'w': return Language.AAW;
					case 'x': return Language.AAX;
					case 'z': return Language.AAZ;
				}
				offset--;
			}
			return Language.AA;
		}

		private static Language? tryParseFromLanguage_ab(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.ABA;
					case 'b': return Language.ABB;
					case 'c': return Language.ABC;
					case 'd': return Language.ABD;
					case 'e': return Language.ABE;
					case 'f': return Language.ABF;
					case 'g': return Language.ABG;
					case 'h': return Language.ABH;
					case 'i': return Language.ABI;
					case 'j': return Language.ABJ;
					case 'l': return Language.ABL;
					case 'm': return Language.ABM;
					case 'n': return Language.ABN;
					case 'o': return Language.ABO;
					case 'p': return Language.ABP;
					case 'q': return Language.ABQ;
					case 'r': return Language.ABR;
					case 's': return Language.ABS;
					case 't': return Language.ABT;
					case 'u': return Language.ABU;
					case 'v': return Language.ABV;
					case 'w': return Language.ABW;
					case 'x': return Language.ABX;
					case 'y': return Language.ABY;
					case 'z': return Language.ABZ;
				}
				offset--;
			}
			return Language.AB;
		}

		private static Language? tryParseFromLanguage_ae(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.AEA;
					case 'b': return Language.AEB;
					case 'c': return Language.AEC;
					case 'd': return Language.AED;
					case 'e': return Language.AEE;
					case 'k': return Language.AEK;
					case 'l': return Language.AEL;
					case 'm': return Language.AEM;
					case 'n': return Language.AEN;
					case 'q': return Language.AEQ;
					case 'r': return Language.AER;
					case 's': return Language.AES;
					case 'u': return Language.AEU;
					case 'w': return Language.AEW;
					case 'y': return Language.AEY;
					case 'z': return Language.AEZ;
				}
				offset--;
			}
			return Language.AE;
		}

		private static Language? tryParseFromLanguage_af(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.AFA;
					case 'b': return Language.AFB;
					case 'd': return Language.AFD;
					case 'e': return Language.AFE;
					case 'g': return Language.AFG;
					case 'h': return Language.AFH;
					case 'i': return Language.AFI;
					case 'k': return Language.AFK;
					case 'n': return Language.AFN;
					case 'o': return Language.AFO;
					case 'p': return Language.AFP;
					case 's': return Language.AFS;
					case 't': return Language.AFT;
					case 'u': return Language.AFU;
					case 'z': return Language.AFZ;
				}
				offset--;
			}
			return Language.AF;
		}

		private static Language? tryParseFromLanguage_ak(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.AKB;
					case 'c': return Language.AKC;
					case 'd': return Language.AKD;
					case 'e': return Language.AKE;
					case 'f': return Language.AKF;
					case 'g': return Language.AKG;
					case 'h': return Language.AKH;
					case 'i': return Language.AKI;
					case 'j': return Language.AKJ;
					case 'k': return Language.AKK;
					case 'l': return Language.AKL;
					case 'm': return Language.AKM;
					case 'o': return Language.AKO;
					case 'p': return Language.AKP;
					case 'q': return Language.AKQ;
					case 'r': return Language.AKR;
					case 's': return Language.AKS;
					case 't': return Language.AKT;
					case 'u': return Language.AKU;
					case 'v': return Language.AKV;
					case 'w': return Language.AKW;
					case 'x': return Language.AKX;
					case 'y': return Language.AKY;
					case 'z': return Language.AKZ;
				}
				offset--;
			}
			return Language.AK;
		}

		private static Language? tryParseFromLanguage_am(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.AMA;
					case 'b': return Language.AMB;
					case 'c': return Language.AMC;
					case 'e': return Language.AME;
					case 'f': return Language.AMF;
					case 'g': return Language.AMG;
					case 'i': return Language.AMI;
					case 'j': return Language.AMJ;
					case 'k': return Language.AMK;
					case 'l': return Language.AML;
					case 'm': return Language.AMM;
					case 'n': return Language.AMN;
					case 'o': return Language.AMO;
					case 'p': return Language.AMP;
					case 'q': return Language.AMQ;
					case 'r': return Language.AMR;
					case 's': return Language.AMS;
					case 't': return Language.AMT;
					case 'u': return Language.AMU;
					case 'v': return Language.AMV;
					case 'w': return Language.AMW;
					case 'x': return Language.AMX;
					case 'y': return Language.AMY;
					case 'z': return Language.AMZ;
				}
				offset--;
			}
			return Language.AM;
		}

		private static Language? tryParseFromLanguage_an(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.ANA;
					case 'b': return Language.ANB;
					case 'c': return Language.ANC;
					case 'd': return Language.AND;
					case 'e': return Language.ANE;
					case 'f': return Language.ANF;
					case 'g': return Language.ANG;
					case 'h': return Language.ANH;
					case 'i': return Language.ANI;
					case 'j': return Language.ANJ;
					case 'k': return Language.ANK;
					case 'l': return Language.ANL;
					case 'm': return Language.ANM;
					case 'n': return Language.ANN;
					case 'o': return Language.ANO;
					case 'p': return Language.ANP;
					case 'q': return Language.ANQ;
					case 'r': return Language.ANR;
					case 's': return Language.ANS;
					case 't': return Language.ANT;
					case 'u': return Language.ANU;
					case 'v': return Language.ANV;
					case 'w': return Language.ANW;
					case 'x': return Language.ANX;
					case 'y': return Language.ANY;
					case 'z': return Language.ANZ;
				}
				offset--;
			}
			return Language.AN;
		}

		private static Language? tryParseFromLanguage_ar(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.ARB;
					case 'c': return Language.ARC;
					case 'd': return Language.ARD;
					case 'e': return Language.ARE;
					case 'h': return Language.ARH;
					case 'i': return Language.ARI;
					case 'j': return Language.ARJ;
					case 'k': return Language.ARK;
					case 'l': return Language.ARL;
					case 'n': return Language.ARN;
					case 'o': return Language.ARO;
					case 'p': return Language.ARP;
					case 'q': return Language.ARQ;
					case 'r': return Language.ARR;
					case 's': return Language.ARS;
					case 't': return Language.ART;
					case 'u': return Language.ARU;
					case 'v': return Language.ARV;
					case 'w': return Language.ARW;
					case 'x': return Language.ARX;
					case 'y': return Language.ARY;
					case 'z': return Language.ARZ;
				}
				offset--;
			}
			return Language.AR;
		}

		private static Language? tryParseFromLanguage_as(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.ASA;
					case 'b': return Language.ASB;
					case 'c': return Language.ASC;
					case 'd': return Language.ASD;
					case 'e': return Language.ASE;
					case 'f': return Language.ASF;
					case 'g': return Language.ASG;
					case 'h': return Language.ASH;
					case 'i': return Language.ASI;
					case 'j': return Language.ASJ;
					case 'k': return Language.ASK;
					case 'l': return Language.ASL;
					case 'n': return Language.ASN;
					case 'o': return Language.ASO;
					case 'p': return Language.ASP;
					case 'q': return Language.ASQ;
					case 'r': return Language.ASR;
					case 's': return Language.ASS;
					case 't': return Language.AST;
					case 'u': return Language.ASU;
					case 'v': return Language.ASV;
					case 'w': return Language.ASW;
					case 'x': return Language.ASX;
					case 'y': return Language.ASY;
					case 'z': return Language.ASZ;
				}
				offset--;
			}
			return Language.AS;
		}

		private static Language? tryParseFromLanguage_av(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.AVB;
					case 'd': return Language.AVD;
					case 'i': return Language.AVI;
					case 'k': return Language.AVK;
					case 'l': return Language.AVL;
					case 'm': return Language.AVM;
					case 'n': return Language.AVN;
					case 'o': return Language.AVO;
					case 's': return Language.AVS;
					case 't': return Language.AVT;
					case 'u': return Language.AVU;
					case 'v': return Language.AVV;
				}
				offset--;
			}
			return Language.AV;
		}

		private static Language? tryParseFromLanguage_ay(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.AYA;
					case 'b': return Language.AYB;
					case 'c': return Language.AYC;
					case 'd': return Language.AYD;
					case 'e': return Language.AYE;
					case 'g': return Language.AYG;
					case 'h': return Language.AYH;
					case 'i': return Language.AYI;
					case 'k': return Language.AYK;
					case 'l': return Language.AYL;
					case 'n': return Language.AYN;
					case 'o': return Language.AYO;
					case 'p': return Language.AYP;
					case 'q': return Language.AYQ;
					case 'r': return Language.AYR;
					case 's': return Language.AYS;
					case 't': return Language.AYT;
					case 'u': return Language.AYU;
					case 'x': return Language.NUN;
					case 'y': return Language.AYY;
					case 'z': return Language.AYZ;
				}
				offset--;
			}
			return Language.AY;
		}

		private static Language? tryParseFromLanguage_az(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.AZA;
					case 'b': return Language.AZB;
					case 'c': return Language.AZC;
					case 'd': return Language.AZD;
					case 'g': return Language.AZG;
					case 'j': return Language.AZJ;
					case 'm': return Language.AZM;
					case 'n': return Language.AZN;
					case 'o': return Language.AZO;
					case 't': return Language.AZT;
					case 'z': return Language.AZZ;
				}
				offset--;
			}
			return Language.AZ;
		}

		private static Language? tryParseFromLanguage_ac(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.ACA;
					case 'b': return Language.ACB;
					case 'd': return Language.ACD;
					case 'e': return Language.ACE;
					case 'f': return Language.ACF;
					case 'h': return Language.ACH;
					case 'i': return Language.ACI;
					case 'k': return Language.ACK;
					case 'l': return Language.ACL;
					case 'm': return Language.ACM;
					case 'n': return Language.ACN;
					case 'p': return Language.ACP;
					case 'q': return Language.ACQ;
					case 'r': return Language.ACR;
					case 's': return Language.ACS;
					case 't': return Language.ACT;
					case 'u': return Language.ACU;
					case 'v': return Language.ACV;
					case 'w': return Language.ACW;
					case 'x': return Language.ACX;
					case 'y': return Language.ACY;
					case 'z': return Language.ACZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ad(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.ADA;
					case 'b': return Language.ADB;
					case 'd': return Language.ADD;
					case 'e': return Language.ADE;
					case 'f': return Language.ADF;
					case 'g': return Language.ADG;
					case 'h': return Language.ADH;
					case 'i': return Language.ADI;
					case 'j': return Language.ADJ;
					case 'l': return Language.ADL;
					case 'n': return Language.ADN;
					case 'o': return Language.ADO;
					case 'p': return Language.DZ;
					case 'q': return Language.ADQ;
					case 'r': return Language.ADR;
					case 's': return Language.ADS;
					case 't': return Language.ADT;
					case 'u': return Language.ADU;
					case 'w': return Language.ADW;
					case 'x': return Language.ADX;
					case 'y': return Language.ADY;
					case 'z': return Language.ADZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ag(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.AGA;
					case 'b': return Language.AGB;
					case 'c': return Language.AGC;
					case 'd': return Language.AGD;
					case 'e': return Language.AGE;
					case 'f': return Language.AGF;
					case 'g': return Language.AGG;
					case 'h': return Language.AGH;
					case 'i': return Language.AGI;
					case 'j': return Language.AGJ;
					case 'k': return Language.AGK;
					case 'l': return Language.AGL;
					case 'm': return Language.AGM;
					case 'n': return Language.AGN;
					case 'o': return Language.AGO;
					case 'p': return Language.AGP;
					case 'q': return Language.AGQ;
					case 'r': return Language.AGR;
					case 's': return Language.AGS;
					case 't': return Language.AGT;
					case 'u': return Language.AGU;
					case 'v': return Language.AGV;
					case 'w': return Language.AGW;
					case 'x': return Language.AGX;
					case 'y': return Language.AGY;
					case 'z': return Language.AGZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ah(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.AHA;
					case 'b': return Language.AHB;
					case 'g': return Language.AHG;
					case 'h': return Language.AHH;
					case 'i': return Language.AHI;
					case 'k': return Language.AHK;
					case 'l': return Language.AHL;
					case 'm': return Language.AHM;
					case 'n': return Language.AHN;
					case 'o': return Language.AHO;
					case 'p': return Language.AHP;
					case 'r': return Language.AHR;
					case 's': return Language.AHS;
					case 't': return Language.AHT;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ai(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.AIA;
					case 'b': return Language.AIB;
					case 'c': return Language.AIC;
					case 'd': return Language.AID;
					case 'e': return Language.AIE;
					case 'f': return Language.AIF;
					case 'g': return Language.AIG;
					case 'h': return Language.AIH;
					case 'i': return Language.AII;
					case 'j': return Language.AIJ;
					case 'k': return Language.AIK;
					case 'l': return Language.AIL;
					case 'm': return Language.AIM;
					case 'n': return Language.AIN;
					case 'o': return Language.AIO;
					case 'p': return Language.AIP;
					case 'q': return Language.AIQ;
					case 'r': return Language.AIR;
					case 's': return Language.AIS;
					case 't': return Language.AIT;
					case 'w': return Language.AIW;
					case 'x': return Language.AIX;
					case 'y': return Language.AIY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_aj(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.AJA;
					case 'g': return Language.AJG;
					case 'i': return Language.AJI;
					case 'n': return Language.AJN;
					case 'p': return Language.AJP;
					case 't': return Language.AJT;
					case 'u': return Language.AJU;
					case 'w': return Language.AJW;
					case 'z': return Language.AJZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_al(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.ALA;
					case 'c': return Language.ALC;
					case 'd': return Language.ALD;
					case 'e': return Language.ALE;
					case 'f': return Language.ALF;
					case 'g': return Language.ALG;
					case 'h': return Language.ALH;
					case 'i': return Language.ALI;
					case 'j': return Language.ALJ;
					case 'k': return Language.ALK;
					case 'l': return Language.ALL;
					case 'm': return Language.ALM;
					case 'n': return Language.ALN;
					case 'o': return Language.ALO;
					case 'p': return Language.ALP;
					case 'q': return Language.ALQ;
					case 'r': return Language.ALR;
					case 's': return Language.ALS;
					case 't': return Language.ALT;
					case 'u': return Language.ALU;
					case 'v': return Language.ALV;
					case 'w': return Language.ALW;
					case 'x': return Language.ALX;
					case 'y': return Language.ALY;
					case 'z': return Language.ALZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ao(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.AOA;
					case 'b': return Language.AOB;
					case 'c': return Language.AOC;
					case 'd': return Language.AOD;
					case 'e': return Language.AOE;
					case 'f': return Language.AOF;
					case 'g': return Language.AOG;
					case 'h': return Language.AOH;
					case 'i': return Language.AOI;
					case 'j': return Language.AOJ;
					case 'k': return Language.AOK;
					case 'l': return Language.AOL;
					case 'm': return Language.AOM;
					case 'n': return Language.AON;
					case 'r': return Language.AOR;
					case 's': return Language.AOS;
					case 't': return Language.AOT;
					case 'u': return Language.AOU;
					case 'x': return Language.AOX;
					case 'z': return Language.AOZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ap(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.APA;
					case 'b': return Language.APB;
					case 'c': return Language.APC;
					case 'd': return Language.APD;
					case 'e': return Language.APE;
					case 'f': return Language.APF;
					case 'g': return Language.APG;
					case 'h': return Language.APH;
					case 'i': return Language.API;
					case 'j': return Language.APJ;
					case 'k': return Language.APK;
					case 'l': return Language.APL;
					case 'm': return Language.APM;
					case 'n': return Language.APN;
					case 'o': return Language.APO;
					case 'p': return Language.APP;
					case 'q': return Language.APQ;
					case 'r': return Language.APR;
					case 's': return Language.APS;
					case 't': return Language.APT;
					case 'u': return Language.APU;
					case 'v': return Language.APV;
					case 'w': return Language.APW;
					case 'x': return Language.APX;
					case 'y': return Language.APY;
					case 'z': return Language.APZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_aq(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.AQA;
					case 'c': return Language.AQC;
					case 'd': return Language.AQD;
					case 'g': return Language.AQG;
					case 'l': return Language.AQL;
					case 'm': return Language.AQM;
					case 'n': return Language.AQN;
					case 'p': return Language.AQP;
					case 'r': return Language.AQR;
					case 't': return Language.AQT;
					case 'z': return Language.AQZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_at(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.ATA;
					case 'b': return Language.ATB;
					case 'c': return Language.ATC;
					case 'd': return Language.ATD;
					case 'e': return Language.ATE;
					case 'g': return Language.ATG;
					case 'h': return Language.ATH;
					case 'i': return Language.ATI;
					case 'j': return Language.ATJ;
					case 'k': return Language.ATK;
					case 'l': return Language.ATL;
					case 'm': return Language.ATM;
					case 'n': return Language.ATN;
					case 'o': return Language.ATO;
					case 'p': return Language.ATP;
					case 'q': return Language.ATQ;
					case 'r': return Language.ATR;
					case 's': return Language.ATS;
					case 't': return Language.ATT;
					case 'u': return Language.ATU;
					case 'v': return Language.ATV;
					case 'w': return Language.ATW;
					case 'x': return Language.ATX;
					case 'y': return Language.ATY;
					case 'z': return Language.ATZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_au(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.AUA;
					case 'b': return Language.AUB;
					case 'c': return Language.AUC;
					case 'd': return Language.AUD;
					case 'e': return Language.KTZ;
					case 'f': return Language.AUF;
					case 'g': return Language.AUG;
					case 'h': return Language.AUH;
					case 'i': return Language.AUI;
					case 'j': return Language.AUJ;
					case 'k': return Language.AUK;
					case 'l': return Language.AUL;
					case 'm': return Language.AUM;
					case 'n': return Language.AUN;
					case 'o': return Language.AUO;
					case 'p': return Language.AUP;
					case 'q': return Language.AUQ;
					case 'r': return Language.AUR;
					case 's': return Language.AUS;
					case 't': return Language.AUT;
					case 'u': return Language.AUU;
					case 'w': return Language.AUW;
					case 'x': return Language.AUX;
					case 'y': return Language.AUY;
					case 'z': return Language.AUZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_aw(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.AWA;
					case 'b': return Language.AWB;
					case 'c': return Language.AWC;
					case 'd': return Language.AWD;
					case 'e': return Language.AWE;
					case 'g': return Language.AWG;
					case 'h': return Language.AWH;
					case 'i': return Language.AWI;
					case 'k': return Language.AWK;
					case 'm': return Language.AWM;
					case 'n': return Language.AWN;
					case 'o': return Language.AWO;
					case 'r': return Language.AWR;
					case 's': return Language.AWS;
					case 't': return Language.AWT;
					case 'u': return Language.AWU;
					case 'v': return Language.AWV;
					case 'w': return Language.AWW;
					case 'x': return Language.AWX;
					case 'y': return Language.AWY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ax(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.AXB;
					case 'e': return Language.AXE;
					case 'g': return Language.AXG;
					case 'k': return Language.AXK;
					case 'l': return Language.AXL;
					case 'm': return Language.AXM;
					case 'x': return Language.AXX;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_b(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return tryParseFromLanguage_ba(text, ref offset);
					case 'e': return tryParseFromLanguage_be(text, ref offset);
					case 'g': return tryParseFromLanguage_bg(text, ref offset);
					case 'h': return tryParseFromLanguage_bh(text, ref offset);
					case 'i': return tryParseFromLanguage_bi(text, ref offset);
					case 'm': return tryParseFromLanguage_bm(text, ref offset);
					case 'n': return tryParseFromLanguage_bn(text, ref offset);
					case 'o': return tryParseFromLanguage_bo(text, ref offset);
					case 'r': return tryParseFromLanguage_br(text, ref offset);
					case 's': return tryParseFromLanguage_bs(text, ref offset);
					case 'b': return tryParseFromLanguage_bb(text, ref offset);
					case 'c': return tryParseFromLanguage_bc(text, ref offset);
					case 'd': return tryParseFromLanguage_bd(text, ref offset);
					case 'f': return tryParseFromLanguage_bf(text, ref offset);
					case 'j': return tryParseFromLanguage_bj(text, ref offset);
					case 'k': return tryParseFromLanguage_bk(text, ref offset);
					case 'l': return tryParseFromLanguage_bl(text, ref offset);
					case 'p': return tryParseFromLanguage_bp(text, ref offset);
					case 'q': return tryParseFromLanguage_bq(text, ref offset);
					case 't': return tryParseFromLanguage_bt(text, ref offset);
					case 'u': return tryParseFromLanguage_bu(text, ref offset);
					case 'v': return tryParseFromLanguage_bv(text, ref offset);
					case 'w': return tryParseFromLanguage_bw(text, ref offset);
					case 'x': return tryParseFromLanguage_bx(text, ref offset);
					case 'y': return tryParseFromLanguage_by(text, ref offset);
					case 'z': return tryParseFromLanguage_bz(text, ref offset);
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ba(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.BAA;
					case 'b': return Language.BAB;
					case 'c': return Language.BAC;
					case 'd': return Language.BAD;
					case 'e': return Language.BAE;
					case 'f': return Language.BAF;
					case 'g': return Language.BAG;
					case 'h': return Language.BAH;
					case 'i': return Language.BAI;
					case 'j': return Language.BAJ;
					case 'l': return Language.BAL;
					case 'n': return Language.BAN;
					case 'o': return Language.BAO;
					case 'p': return Language.BAP;
					case 'r': return Language.BAR;
					case 's': return Language.BAS;
					case 't': return Language.BAT;
					case 'u': return Language.BAU;
					case 'v': return Language.BAV;
					case 'w': return Language.BAW;
					case 'x': return Language.BAX;
					case 'y': return Language.BAY;
					case 'z': return Language.BAZ;
				}
				offset--;
			}
			return Language.BA;
		}

		private static Language? tryParseFromLanguage_be(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.BEA;
					case 'b': return Language.BEB;
					case 'c': return Language.BEC;
					case 'd': return Language.BED;
					case 'e': return Language.BEE;
					case 'f': return Language.BEF;
					case 'g': return Language.BEG;
					case 'h': return Language.BEH;
					case 'i': return Language.BEI;
					case 'j': return Language.BEJ;
					case 'k': return Language.BEK;
					case 'm': return Language.BEM;
					case 'o': return Language.BEO;
					case 'p': return Language.BEP;
					case 'q': return Language.BEQ;
					case 'r': return Language.BER;
					case 's': return Language.BES;
					case 't': return Language.BET;
					case 'u': return Language.BEU;
					case 'v': return Language.BEV;
					case 'w': return Language.BEW;
					case 'x': return Language.BEX;
					case 'y': return Language.BEY;
					case 'z': return Language.BEZ;
				}
				offset--;
			}
			return Language.BE;
		}

		private static Language? tryParseFromLanguage_bg(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.BGA;
					case 'b': return Language.BGB;
					case 'c': return Language.BGC;
					case 'd': return Language.BGD;
					case 'e': return Language.BGE;
					case 'f': return Language.BGF;
					case 'g': return Language.BGG;
					case 'i': return Language.BGI;
					case 'j': return Language.BGJ;
					case 'k': return Language.BGK;
					case 'l': return Language.BGL;
					case 'm': return Language.BCG;
					case 'n': return Language.BGN;
					case 'o': return Language.BGO;
					case 'p': return Language.BGP;
					case 'q': return Language.BGQ;
					case 'r': return Language.BGR;
					case 's': return Language.BGS;
					case 't': return Language.BGT;
					case 'u': return Language.BGU;
					case 'v': return Language.BGV;
					case 'w': return Language.BGW;
					case 'x': return Language.BGX;
					case 'y': return Language.BGY;
					case 'z': return Language.BGZ;
				}
				offset--;
			}
			return Language.BG;
		}

		private static Language? tryParseFromLanguage_bh(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.BHA;
					case 'b': return Language.BHB;
					case 'c': return Language.BHC;
					case 'd': return Language.BHD;
					case 'e': return Language.BHE;
					case 'f': return Language.BHF;
					case 'g': return Language.BHG;
					case 'h': return Language.BHH;
					case 'i': return Language.BHI;
					case 'j': return Language.BHJ;
					case 'k': return Language.BHK;
					case 'l': return Language.BHL;
					case 'm': return Language.BHM;
					case 'n': return Language.BHN;
					case 'o': return Language.BHO;
					case 'p': return Language.BHP;
					case 'q': return Language.BHQ;
					case 'r': return Language.BHR;
					case 's': return Language.BHS;
					case 't': return Language.BHT;
					case 'u': return Language.BHU;
					case 'v': return Language.BHV;
					case 'w': return Language.BHW;
					case 'x': return Language.BHX;
					case 'y': return Language.BHY;
					case 'z': return Language.BHZ;
				}
				offset--;
			}
			return Language.BH;
		}

		private static Language? tryParseFromLanguage_bi(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.BIA;
					case 'b': return Language.BIB;
					case 'c': return Language.BIC;
					case 'd': return Language.BID;
					case 'e': return Language.BIE;
					case 'f': return Language.BIF;
					case 'g': return Language.BIG;
					case 'j': return Language.BIJ;
					case 'k': return Language.BIK;
					case 'l': return Language.BIL;
					case 'm': return Language.BIM;
					case 'n': return Language.BIN;
					case 'o': return Language.BIO;
					case 'p': return Language.BIP;
					case 'q': return Language.BIQ;
					case 'r': return Language.BIR;
					case 't': return Language.BIT;
					case 'u': return Language.BIU;
					case 'v': return Language.BIV;
					case 'w': return Language.BIW;
					case 'x': return Language.BIX;
					case 'y': return Language.BIY;
					case 'z': return Language.BIZ;
				}
				offset--;
			}
			return Language.BI;
		}

		private static Language? tryParseFromLanguage_bm(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.BMA;
					case 'b': return Language.BMB;
					case 'c': return Language.BMC;
					case 'd': return Language.BMD;
					case 'e': return Language.BME;
					case 'f': return Language.BMF;
					case 'g': return Language.BMG;
					case 'h': return Language.BMH;
					case 'i': return Language.BMI;
					case 'j': return Language.BMJ;
					case 'k': return Language.BMK;
					case 'l': return Language.BML;
					case 'm': return Language.BMM;
					case 'n': return Language.BMN;
					case 'o': return Language.BMO;
					case 'p': return Language.BMP;
					case 'q': return Language.BMQ;
					case 'r': return Language.BMR;
					case 's': return Language.BMS;
					case 't': return Language.BMT;
					case 'u': return Language.BMU;
					case 'v': return Language.BMV;
					case 'w': return Language.BMW;
					case 'x': return Language.BMX;
					case 'y': return Language.BMY;
					case 'z': return Language.BMZ;
				}
				offset--;
			}
			return Language.BM;
		}

		private static Language? tryParseFromLanguage_bn(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.BNA;
					case 'b': return Language.BNB;
					case 'c': return Language.BNC;
					case 'd': return Language.BND;
					case 'e': return Language.BNE;
					case 'f': return Language.BNF;
					case 'g': return Language.BNG;
					case 'i': return Language.BNI;
					case 'j': return Language.BNJ;
					case 'k': return Language.BNK;
					case 'l': return Language.BNL;
					case 'm': return Language.BNM;
					case 'n': return Language.BNN;
					case 'o': return Language.BNO;
					case 'p': return Language.BNP;
					case 'q': return Language.BNQ;
					case 'r': return Language.BNR;
					case 's': return Language.BNS;
					case 't': return Language.BNT;
					case 'u': return Language.BNU;
					case 'v': return Language.BNV;
					case 'w': return Language.BNW;
					case 'x': return Language.BNX;
					case 'y': return Language.BNY;
					case 'z': return Language.BNZ;
				}
				offset--;
			}
			return Language.BN;
		}

		private static Language? tryParseFromLanguage_bo(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.BOA;
					case 'b': return Language.BOB;
					case 'e': return Language.BOE;
					case 'f': return Language.BOF;
					case 'g': return Language.BOG;
					case 'h': return Language.BOH;
					case 'i': return Language.BOI;
					case 'j': return Language.BOJ;
					case 'k': return Language.BOK;
					case 'l': return Language.BOL;
					case 'm': return Language.BOM;
					case 'n': return Language.BON;
					case 'o': return Language.BOO;
					case 'p': return Language.BOP;
					case 'q': return Language.BOQ;
					case 'r': return Language.BOR;
					case 't': return Language.BOT;
					case 'u': return Language.BOU;
					case 'v': return Language.BOV;
					case 'w': return Language.BOW;
					case 'x': return Language.BOX;
					case 'y': return Language.BOY;
					case 'z': return Language.BOZ;
				}
				offset--;
			}
			return Language.BO;
		}

		private static Language? tryParseFromLanguage_br(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.BRA;
					case 'b': return Language.BRB;
					case 'c': return Language.BRC;
					case 'd': return Language.BRD;
					case 'f': return Language.BRF;
					case 'g': return Language.BRG;
					case 'h': return Language.BRH;
					case 'i': return Language.BRI;
					case 'j': return Language.BRJ;
					case 'k': return Language.BRK;
					case 'l': return Language.BRL;
					case 'm': return Language.BRM;
					case 'n': return Language.BRN;
					case 'o': return Language.BRO;
					case 'p': return Language.BRP;
					case 'q': return Language.BRQ;
					case 'r': return Language.BRR;
					case 's': return Language.BRS;
					case 't': return Language.BRT;
					case 'u': return Language.BRU;
					case 'v': return Language.BRV;
					case 'w': return Language.BRW;
					case 'x': return Language.BRX;
					case 'y': return Language.BRY;
					case 'z': return Language.BRZ;
				}
				offset--;
			}
			return Language.BR;
		}

		private static Language? tryParseFromLanguage_bs(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.BSA;
					case 'b': return Language.BSB;
					case 'c': return Language.BSC;
					case 'e': return Language.BSE;
					case 'f': return Language.BSF;
					case 'g': return Language.BSG;
					case 'h': return Language.BSH;
					case 'i': return Language.BSI;
					case 'j': return Language.BSJ;
					case 'k': return Language.BSK;
					case 'l': return Language.BSL;
					case 'm': return Language.BSM;
					case 'n': return Language.BSN;
					case 'o': return Language.BSO;
					case 'p': return Language.BSP;
					case 'q': return Language.BSQ;
					case 'r': return Language.BSR;
					case 's': return Language.BSS;
					case 't': return Language.BST;
					case 'u': return Language.BSU;
					case 'v': return Language.BSV;
					case 'w': return Language.BSW;
					case 'x': return Language.BSX;
					case 'y': return Language.BSY;
				}
				offset--;
			}
			return Language.BS;
		}

		private static Language? tryParseFromLanguage_bb(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.BBA;
					case 'b': return Language.BBB;
					case 'c': return Language.BBC;
					case 'd': return Language.BBD;
					case 'e': return Language.BBE;
					case 'f': return Language.BBF;
					case 'g': return Language.BBG;
					case 'h': return Language.BBH;
					case 'i': return Language.BBI;
					case 'j': return Language.BBJ;
					case 'k': return Language.BBK;
					case 'l': return Language.BBL;
					case 'm': return Language.BBM;
					case 'n': return Language.BBN;
					case 'o': return Language.BBO;
					case 'p': return Language.BBP;
					case 'q': return Language.BBQ;
					case 'r': return Language.BBR;
					case 's': return Language.BBS;
					case 't': return Language.BBT;
					case 'u': return Language.BBU;
					case 'v': return Language.BBV;
					case 'w': return Language.BBW;
					case 'x': return Language.BBX;
					case 'y': return Language.BBY;
					case 'z': return Language.BBZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_bc(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.BCA;
					case 'b': return Language.BCB;
					case 'c': return Language.BCC;
					case 'd': return Language.BCD;
					case 'e': return Language.BCE;
					case 'f': return Language.BCF;
					case 'g': return Language.BCG;
					case 'h': return Language.BCH;
					case 'i': return Language.BCI;
					case 'j': return Language.BCJ;
					case 'k': return Language.BCK;
					case 'l': return Language.BCL;
					case 'm': return Language.BCM;
					case 'n': return Language.BCN;
					case 'o': return Language.BCO;
					case 'p': return Language.BCP;
					case 'q': return Language.BCQ;
					case 'r': return Language.BCR;
					case 's': return Language.BCS;
					case 't': return Language.BCT;
					case 'u': return Language.BCU;
					case 'v': return Language.BCV;
					case 'w': return Language.BCW;
					case 'y': return Language.BCY;
					case 'z': return Language.BCZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_bd(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.BDA;
					case 'b': return Language.BDB;
					case 'c': return Language.BDC;
					case 'd': return Language.BDD;
					case 'e': return Language.BDE;
					case 'f': return Language.BDF;
					case 'g': return Language.BDG;
					case 'h': return Language.BDH;
					case 'i': return Language.BDI;
					case 'j': return Language.BDJ;
					case 'k': return Language.BDK;
					case 'l': return Language.BDL;
					case 'm': return Language.BDM;
					case 'n': return Language.BDN;
					case 'o': return Language.BDO;
					case 'p': return Language.BDP;
					case 'q': return Language.BDQ;
					case 'r': return Language.BDR;
					case 's': return Language.BDS;
					case 't': return Language.BDT;
					case 'u': return Language.BDU;
					case 'v': return Language.BDV;
					case 'w': return Language.BDW;
					case 'x': return Language.BDX;
					case 'y': return Language.BDY;
					case 'z': return Language.BDZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_bf(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.BFA;
					case 'b': return Language.BFB;
					case 'c': return Language.BFC;
					case 'd': return Language.BFD;
					case 'e': return Language.BFE;
					case 'f': return Language.BFF;
					case 'g': return Language.BFG;
					case 'h': return Language.BFH;
					case 'i': return Language.BFI;
					case 'j': return Language.BFJ;
					case 'k': return Language.BFK;
					case 'l': return Language.BFL;
					case 'm': return Language.BFM;
					case 'n': return Language.BFN;
					case 'o': return Language.BFO;
					case 'p': return Language.BFP;
					case 'q': return Language.BFQ;
					case 'r': return Language.BFR;
					case 's': return Language.BFS;
					case 't': return Language.BFT;
					case 'u': return Language.BFU;
					case 'w': return Language.BFW;
					case 'x': return Language.BFX;
					case 'y': return Language.BFY;
					case 'z': return Language.BFZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_bj(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.BJA;
					case 'b': return Language.BJB;
					case 'c': return Language.BJC;
					case 'd': return Language.DRL;
					case 'e': return Language.BJE;
					case 'f': return Language.BJF;
					case 'g': return Language.BJG;
					case 'h': return Language.BJH;
					case 'i': return Language.BJI;
					case 'j': return Language.BJJ;
					case 'k': return Language.BJK;
					case 'l': return Language.BJL;
					case 'm': return Language.BJM;
					case 'n': return Language.BJN;
					case 'o': return Language.BJO;
					case 'p': return Language.BJP;
					case 'q': return Language.BJQ;
					case 'r': return Language.BJR;
					case 's': return Language.BJS;
					case 't': return Language.BJT;
					case 'u': return Language.BJU;
					case 'v': return Language.BJV;
					case 'w': return Language.BJW;
					case 'x': return Language.BJX;
					case 'y': return Language.BJY;
					case 'z': return Language.BJZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_bk(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.BKA;
					case 'b': return Language.BKB;
					case 'c': return Language.BKC;
					case 'd': return Language.BKD;
					case 'f': return Language.BKF;
					case 'g': return Language.BKG;
					case 'h': return Language.BKH;
					case 'i': return Language.BKI;
					case 'j': return Language.BKJ;
					case 'k': return Language.BKK;
					case 'l': return Language.BKL;
					case 'm': return Language.BKM;
					case 'n': return Language.BKN;
					case 'o': return Language.BKO;
					case 'p': return Language.BKP;
					case 'q': return Language.BKQ;
					case 'r': return Language.BKR;
					case 's': return Language.BKS;
					case 't': return Language.BKT;
					case 'u': return Language.BKU;
					case 'v': return Language.BKV;
					case 'w': return Language.BKW;
					case 'x': return Language.BKX;
					case 'y': return Language.BKY;
					case 'z': return Language.BKZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_bl(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.BLA;
					case 'b': return Language.BLB;
					case 'c': return Language.BLC;
					case 'd': return Language.BLD;
					case 'e': return Language.BLE;
					case 'f': return Language.BLF;
					case 'g': return Language.BLG;
					case 'h': return Language.BLH;
					case 'i': return Language.BLI;
					case 'j': return Language.BLJ;
					case 'k': return Language.BLK;
					case 'l': return Language.BLL;
					case 'm': return Language.BLM;
					case 'n': return Language.BLN;
					case 'o': return Language.BLO;
					case 'p': return Language.BLP;
					case 'q': return Language.BLQ;
					case 'r': return Language.BLR;
					case 's': return Language.BLS;
					case 't': return Language.BLT;
					case 'v': return Language.BLV;
					case 'w': return Language.BLW;
					case 'x': return Language.BLX;
					case 'y': return Language.BLY;
					case 'z': return Language.BLZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_bp(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.BPA;
					case 'b': return Language.BPB;
					case 'd': return Language.BPD;
					case 'g': return Language.BPG;
					case 'h': return Language.BPH;
					case 'i': return Language.BPI;
					case 'j': return Language.BPJ;
					case 'k': return Language.BPK;
					case 'l': return Language.BPL;
					case 'm': return Language.BPM;
					case 'n': return Language.BPN;
					case 'o': return Language.BPO;
					case 'p': return Language.BPP;
					case 'q': return Language.BPQ;
					case 'r': return Language.BPR;
					case 's': return Language.BPS;
					case 't': return Language.BPT;
					case 'u': return Language.BPU;
					case 'v': return Language.BPV;
					case 'w': return Language.BPW;
					case 'x': return Language.BPX;
					case 'y': return Language.BPY;
					case 'z': return Language.BPZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_bq(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.BQA;
					case 'b': return Language.BQB;
					case 'c': return Language.BQC;
					case 'd': return Language.BQD;
					case 'f': return Language.BQF;
					case 'g': return Language.BQG;
					case 'h': return Language.BQH;
					case 'i': return Language.BQI;
					case 'j': return Language.BQJ;
					case 'k': return Language.BQK;
					case 'l': return Language.BQL;
					case 'm': return Language.BQM;
					case 'n': return Language.BQN;
					case 'o': return Language.BQO;
					case 'p': return Language.BQP;
					case 'q': return Language.BQQ;
					case 'r': return Language.BQR;
					case 's': return Language.BQS;
					case 't': return Language.BQT;
					case 'u': return Language.BQU;
					case 'v': return Language.BQV;
					case 'w': return Language.BQW;
					case 'x': return Language.BQX;
					case 'y': return Language.BQY;
					case 'z': return Language.BQZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_bt(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.BTA;
					case 'b': return Language.BTB;
					case 'c': return Language.BTC;
					case 'd': return Language.BTD;
					case 'e': return Language.BTE;
					case 'f': return Language.BTF;
					case 'g': return Language.BTG;
					case 'h': return Language.BTH;
					case 'i': return Language.BTI;
					case 'j': return Language.BTJ;
					case 'k': return Language.BTK;
					case 'l': return Language.BTL;
					case 'm': return Language.BTM;
					case 'n': return Language.BTN;
					case 'o': return Language.BTO;
					case 'p': return Language.BTP;
					case 'q': return Language.BTQ;
					case 'r': return Language.BTR;
					case 's': return Language.BTS;
					case 't': return Language.BTT;
					case 'u': return Language.BTU;
					case 'v': return Language.BTV;
					case 'w': return Language.BTW;
					case 'x': return Language.BTX;
					case 'y': return Language.BTY;
					case 'z': return Language.BTZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_bu(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.BUA;
					case 'b': return Language.BUB;
					case 'c': return Language.BUC;
					case 'd': return Language.BUD;
					case 'e': return Language.BUE;
					case 'f': return Language.BUF;
					case 'g': return Language.BUG;
					case 'h': return Language.BUH;
					case 'i': return Language.BUI;
					case 'j': return Language.BUJ;
					case 'k': return Language.BUK;
					case 'm': return Language.BUM;
					case 'n': return Language.BUN;
					case 'o': return Language.BUO;
					case 'p': return Language.BUP;
					case 'q': return Language.BUQ;
					case 's': return Language.BUS;
					case 't': return Language.BUT;
					case 'u': return Language.BUU;
					case 'v': return Language.BUV;
					case 'w': return Language.BUW;
					case 'x': return Language.BUX;
					case 'y': return Language.BUY;
					case 'z': return Language.BUZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_bv(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.BVA;
					case 'b': return Language.BVB;
					case 'c': return Language.BVC;
					case 'd': return Language.BVD;
					case 'e': return Language.BVE;
					case 'f': return Language.BVF;
					case 'g': return Language.BVG;
					case 'h': return Language.BVH;
					case 'i': return Language.BVI;
					case 'j': return Language.BVJ;
					case 'k': return Language.BVK;
					case 'l': return Language.BVL;
					case 'm': return Language.BVM;
					case 'n': return Language.BVN;
					case 'o': return Language.BVO;
					case 'p': return Language.BVP;
					case 'q': return Language.BVQ;
					case 'r': return Language.BVR;
					case 't': return Language.BVT;
					case 'u': return Language.BVU;
					case 'v': return Language.BVV;
					case 'w': return Language.BVW;
					case 'x': return Language.BVX;
					case 'y': return Language.BVY;
					case 'z': return Language.BVZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_bw(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.BWA;
					case 'b': return Language.BWB;
					case 'c': return Language.BWC;
					case 'd': return Language.BWD;
					case 'e': return Language.BWE;
					case 'f': return Language.BWF;
					case 'g': return Language.BWG;
					case 'h': return Language.BWH;
					case 'i': return Language.BWI;
					case 'j': return Language.BWJ;
					case 'k': return Language.BWK;
					case 'l': return Language.BWL;
					case 'm': return Language.BWM;
					case 'n': return Language.BWN;
					case 'o': return Language.BWO;
					case 'p': return Language.BWP;
					case 'q': return Language.BWQ;
					case 'r': return Language.BWR;
					case 's': return Language.BWS;
					case 't': return Language.BWT;
					case 'u': return Language.BWU;
					case 'w': return Language.BWW;
					case 'x': return Language.BWX;
					case 'y': return Language.BWY;
					case 'z': return Language.BWZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_bx(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.BXA;
					case 'b': return Language.BXB;
					case 'c': return Language.BXC;
					case 'd': return Language.BXD;
					case 'e': return Language.BXE;
					case 'f': return Language.BXF;
					case 'g': return Language.BXG;
					case 'h': return Language.BXH;
					case 'i': return Language.BXI;
					case 'j': return Language.BXJ;
					case 'k': return Language.BXK;
					case 'l': return Language.BXL;
					case 'm': return Language.BXM;
					case 'n': return Language.BXN;
					case 'o': return Language.BXO;
					case 'p': return Language.BXP;
					case 'q': return Language.BXQ;
					case 'r': return Language.BXR;
					case 's': return Language.BXS;
					case 'u': return Language.BXU;
					case 'v': return Language.BXV;
					case 'w': return Language.BXW;
					case 'x': return Language.BXX;
					case 'z': return Language.BXZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_by(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.BYA;
					case 'b': return Language.BYB;
					case 'c': return Language.BYC;
					case 'd': return Language.BYD;
					case 'e': return Language.BYE;
					case 'f': return Language.BYF;
					case 'g': return Language.BYG;
					case 'h': return Language.BYH;
					case 'i': return Language.BYI;
					case 'j': return Language.BYJ;
					case 'k': return Language.BYK;
					case 'l': return Language.BYL;
					case 'm': return Language.BYM;
					case 'n': return Language.BYN;
					case 'o': return Language.BYO;
					case 'p': return Language.BYP;
					case 'q': return Language.BYQ;
					case 'r': return Language.BYR;
					case 's': return Language.BYS;
					case 't': return Language.BYT;
					case 'v': return Language.BYV;
					case 'w': return Language.BYW;
					case 'x': return Language.BYX;
					case 'y': return Language.BYY;
					case 'z': return Language.BYZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_bz(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.BZA;
					case 'b': return Language.BZB;
					case 'c': return Language.BZC;
					case 'd': return Language.BZD;
					case 'e': return Language.BZE;
					case 'f': return Language.BZF;
					case 'g': return Language.BZG;
					case 'h': return Language.BZH;
					case 'i': return Language.BZI;
					case 'j': return Language.BZJ;
					case 'k': return Language.BZK;
					case 'l': return Language.BZL;
					case 'm': return Language.BZM;
					case 'n': return Language.BZN;
					case 'o': return Language.BZO;
					case 'p': return Language.BZP;
					case 'q': return Language.BZQ;
					case 'r': return Language.BZR;
					case 's': return Language.BZS;
					case 't': return Language.BZT;
					case 'u': return Language.BZU;
					case 'v': return Language.BZV;
					case 'w': return Language.BZW;
					case 'x': return Language.BZX;
					case 'y': return Language.BZY;
					case 'z': return Language.BZZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_c(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return tryParseFromLanguage_ca(text, ref offset);
					case 'e': return tryParseFromLanguage_ce(text, ref offset);
					case 'h': return tryParseFromLanguage_ch(text, ref offset);
					case 'o': return tryParseFromLanguage_co(text, ref offset);
					case 'r': return tryParseFromLanguage_cr(text, ref offset);
					case 's': return tryParseFromLanguage_cs(text, ref offset);
					case 'u': return tryParseFromLanguage_cu(text, ref offset);
					case 'v': return tryParseFromLanguage_cv(text, ref offset);
					case 'y': return tryParseFromLanguage_cy(text, ref offset);
					case 'b': return tryParseFromLanguage_cb(text, ref offset);
					case 'c': return tryParseFromLanguage_cc(text, ref offset);
					case 'd': return tryParseFromLanguage_cd(text, ref offset);
					case 'f': return tryParseFromLanguage_cf(text, ref offset);
					case 'g': return tryParseFromLanguage_cg(text, ref offset);
					case 'i': return tryParseFromLanguage_ci(text, ref offset);
					case 'j': return tryParseFromLanguage_cj(text, ref offset);
					case 'k': return tryParseFromLanguage_ck(text, ref offset);
					case 'l': return tryParseFromLanguage_cl(text, ref offset);
					case 'm': return tryParseFromLanguage_cm(text, ref offset);
					case 'n': return tryParseFromLanguage_cn(text, ref offset);
					case 'p': return tryParseFromLanguage_cp(text, ref offset);
					case 'q': return tryParseFromLanguage_cq(text, ref offset);
					case 't': return tryParseFromLanguage_ct(text, ref offset);
					case 'w': return tryParseFromLanguage_cw(text, ref offset);
					case 'z': return tryParseFromLanguage_cz(text, ref offset);
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ca(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.CAA;
					case 'b': return Language.CAB;
					case 'c': return Language.CAC;
					case 'd': return Language.CAD;
					case 'e': return Language.CAE;
					case 'f': return Language.CAF;
					case 'g': return Language.CAG;
					case 'h': return Language.CAH;
					case 'i': return Language.CAI;
					case 'j': return Language.CAJ;
					case 'k': return Language.CAK;
					case 'l': return Language.CAL;
					case 'm': return Language.CAM;
					case 'n': return Language.CAN;
					case 'o': return Language.CAO;
					case 'p': return Language.CAP;
					case 'q': return Language.CAQ;
					case 'r': return Language.CAR;
					case 's': return Language.CAS;
					case 'u': return Language.CAU;
					case 'v': return Language.CAV;
					case 'w': return Language.CAW;
					case 'x': return Language.CAX;
					case 'y': return Language.CAY;
					case 'z': return Language.CAZ;
				}
				offset--;
			}
			return Language.CA;
		}

		private static Language? tryParseFromLanguage_ce(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.CEA;
					case 'b': return Language.CEB;
					case 'g': return Language.CEG;
					case 'k': return Language.CEK;
					case 'l': return Language.CEL;
					case 'n': return Language.CEN;
					case 't': return Language.CET;
				}
				offset--;
			}
			return Language.CE;
		}

		private static Language? tryParseFromLanguage_ch(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.CHB;
					case 'c': return Language.CHC;
					case 'd': return Language.CHD;
					case 'f': return Language.CHF;
					case 'g': return Language.CHG;
					case 'h': return Language.CHH;
					case 'j': return Language.CHJ;
					case 'k': return Language.CHK;
					case 'l': return Language.CHL;
					case 'm': return Language.CHM;
					case 'n': return Language.CHN;
					case 'o': return Language.CHO;
					case 'p': return Language.CHP;
					case 'q': return Language.CHQ;
					case 'r': return Language.CHR;
					case 't': return Language.CHT;
					case 'w': return Language.CHW;
					case 'x': return Language.CHX;
					case 'y': return Language.CHY;
					case 'z': return Language.CHZ;
				}
				offset--;
			}
			return Language.CH;
		}

		private static Language? tryParseFromLanguage_co(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.COA;
					case 'b': return Language.COB;
					case 'c': return Language.COC;
					case 'd': return Language.COD;
					case 'e': return Language.COE;
					case 'f': return Language.COF;
					case 'g': return Language.COG;
					case 'h': return Language.COH;
					case 'j': return Language.COJ;
					case 'k': return Language.COK;
					case 'l': return Language.COL;
					case 'm': return Language.COM;
					case 'n': return Language.CON;
					case 'o': return Language.COO;
					case 'p': return Language.COP;
					case 'q': return Language.COQ;
					case 't': return Language.COT;
					case 'u': return Language.COU;
					case 'v': return Language.COV;
					case 'w': return Language.COW;
					case 'x': return Language.COX;
					case 'y': return Language.PIJ;
					case 'z': return Language.COZ;
				}
				offset--;
			}
			return Language.CO;
		}

		private static Language? tryParseFromLanguage_cr(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.CRA;
					case 'b': return Language.CRB;
					case 'c': return Language.CRC;
					case 'd': return Language.CRD;
					case 'f': return Language.CRF;
					case 'g': return Language.CRG;
					case 'h': return Language.CRH;
					case 'i': return Language.CRI;
					case 'j': return Language.CRJ;
					case 'k': return Language.CRK;
					case 'l': return Language.CRL;
					case 'm': return Language.CRM;
					case 'n': return Language.CRN;
					case 'o': return Language.CRO;
					case 'p': return Language.CRP;
					case 'q': return Language.CRQ;
					case 'r': return Language.CRR;
					case 's': return Language.CRS;
					case 't': return Language.CRT;
					case 'v': return Language.CRV;
					case 'w': return Language.CRW;
					case 'x': return Language.CRX;
					case 'y': return Language.CRY;
					case 'z': return Language.CRZ;
				}
				offset--;
			}
			return Language.CR;
		}

		private static Language? tryParseFromLanguage_cs(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.CSA;
					case 'b': return Language.CSB;
					case 'c': return Language.CSC;
					case 'd': return Language.CSD;
					case 'e': return Language.CSE;
					case 'f': return Language.CSF;
					case 'g': return Language.CSG;
					case 'h': return Language.CSH;
					case 'i': return Language.CSI;
					case 'j': return Language.CSJ;
					case 'k': return Language.CSK;
					case 'l': return Language.CSL;
					case 'm': return Language.CSM;
					case 'n': return Language.CSN;
					case 'o': return Language.CSO;
					case 'q': return Language.CSQ;
					case 'r': return Language.CSR;
					case 's': return Language.CSS;
					case 't': return Language.CST;
					case 'u': return Language.CSU;
					case 'v': return Language.CSV;
					case 'w': return Language.CSW;
					case 'y': return Language.CSY;
					case 'z': return Language.CSZ;
				}
				offset--;
			}
			return Language.CS;
		}

		private static Language? tryParseFromLanguage_cu(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.CUA;
					case 'b': return Language.CUB;
					case 'c': return Language.CUC;
					case 'g': return Language.CUG;
					case 'h': return Language.CUH;
					case 'i': return Language.CUI;
					case 'j': return Language.CUJ;
					case 'k': return Language.CUK;
					case 'l': return Language.CUL;
					case 'm': return Language.CUM;
					case 'o': return Language.CUO;
					case 'p': return Language.CUP;
					case 'q': return Language.CUQ;
					case 'r': return Language.CUR;
					case 's': return Language.CUS;
					case 't': return Language.CUT;
					case 'u': return Language.CUU;
					case 'v': return Language.CUV;
					case 'w': return Language.CUW;
					case 'x': return Language.CUX;
				}
				offset--;
			}
			return Language.CU;
		}

		private static Language? tryParseFromLanguage_cv(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'g': return Language.CVG;
					case 'n': return Language.CVN;
				}
				offset--;
			}
			return Language.CV;
		}

		private static Language? tryParseFromLanguage_cy(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.CYA;
					case 'b': return Language.CYB;
					case 'o': return Language.CYO;
				}
				offset--;
			}
			return Language.CY;
		}

		private static Language? tryParseFromLanguage_cb(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.CBA;
					case 'b': return Language.CBB;
					case 'c': return Language.CBC;
					case 'd': return Language.CBD;
					case 'e': return Language.CBE;
					case 'g': return Language.CBG;
					case 'h': return Language.CBH;
					case 'i': return Language.CBI;
					case 'j': return Language.CBJ;
					case 'k': return Language.CBK;
					case 'l': return Language.CBL;
					case 'n': return Language.CBN;
					case 'o': return Language.CBO;
					case 'q': return Language.CBQ;
					case 'r': return Language.CBR;
					case 's': return Language.CBS;
					case 't': return Language.CBT;
					case 'u': return Language.CBU;
					case 'v': return Language.CBV;
					case 'w': return Language.CBW;
					case 'y': return Language.CBY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_cc(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.CCA;
					case 'c': return Language.CCC;
					case 'd': return Language.CCD;
					case 'e': return Language.CCE;
					case 'g': return Language.CCG;
					case 'h': return Language.CCH;
					case 'j': return Language.CCJ;
					case 'l': return Language.CCL;
					case 'm': return Language.CCM;
					case 'n': return Language.CCN;
					case 'o': return Language.CCO;
					case 'p': return Language.CCP;
					case 'q': return Language.RKI;
					case 'r': return Language.CCR;
					case 's': return Language.CCS;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_cd(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.CDA;
					case 'c': return Language.CDC;
					case 'd': return Language.CDD;
					case 'e': return Language.CDE;
					case 'f': return Language.CDF;
					case 'g': return Language.CDG;
					case 'h': return Language.CDH;
					case 'i': return Language.CDI;
					case 'j': return Language.CDJ;
					case 'm': return Language.CDM;
					case 'n': return Language.CDN;
					case 'o': return Language.CDO;
					case 'r': return Language.CDR;
					case 's': return Language.CDS;
					case 'y': return Language.CDY;
					case 'z': return Language.CDZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_cf(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.CFA;
					case 'd': return Language.CFD;
					case 'g': return Language.CFG;
					case 'm': return Language.CFM;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_cg(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.CGA;
					case 'c': return Language.CGC;
					case 'g': return Language.CGG;
					case 'k': return Language.CGK;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ci(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.CIA;
					case 'b': return Language.CIB;
					case 'c': return Language.CIC;
					case 'd': return Language.CID;
					case 'e': return Language.CIE;
					case 'h': return Language.CIH;
					case 'k': return Language.CIK;
					case 'm': return Language.CIM;
					case 'n': return Language.CIN;
					case 'p': return Language.CIP;
					case 'r': return Language.CIR;
					case 'w': return Language.CIW;
					case 'y': return Language.CIY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_cj(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.CJA;
					case 'e': return Language.CJE;
					case 'h': return Language.CJH;
					case 'i': return Language.CJI;
					case 'k': return Language.CJK;
					case 'm': return Language.CJM;
					case 'n': return Language.CJN;
					case 'o': return Language.CJO;
					case 'p': return Language.CJP;
					case 'r': return Language.MOM;
					case 's': return Language.CJS;
					case 'v': return Language.CJV;
					case 'y': return Language.CJY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ck(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.CMR;
					case 'b': return Language.CKB;
					case 'h': return Language.CKH;
					case 'l': return Language.CKL;
					case 'n': return Language.CKN;
					case 'o': return Language.CKO;
					case 'q': return Language.CKQ;
					case 'r': return Language.CKR;
					case 's': return Language.CKS;
					case 't': return Language.CKT;
					case 'u': return Language.CKU;
					case 'v': return Language.CKV;
					case 'x': return Language.CKX;
					case 'y': return Language.CKY;
					case 'z': return Language.CKZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_cl(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.CLA;
					case 'c': return Language.CLC;
					case 'd': return Language.CLD;
					case 'e': return Language.CLE;
					case 'h': return Language.CLH;
					case 'i': return Language.CLI;
					case 'j': return Language.CLJ;
					case 'k': return Language.CLK;
					case 'l': return Language.CLL;
					case 'm': return Language.CLM;
					case 'o': return Language.CLO;
					case 't': return Language.CLT;
					case 'u': return Language.CLU;
					case 'w': return Language.CLW;
					case 'y': return Language.CLY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_cm(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.CMA;
					case 'c': return Language.CMC;
					case 'e': return Language.CME;
					case 'g': return Language.CMG;
					case 'i': return Language.CMI;
					case 'k': return Language.XCH;
					case 'l': return Language.CML;
					case 'm': return Language.CMM;
					case 'n': return Language.CMN;
					case 'o': return Language.CMO;
					case 'r': return Language.CMR;
					case 's': return Language.CMS;
					case 't': return Language.CMT;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_cn(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.CNA;
					case 'b': return Language.CNB;
					case 'c': return Language.CNC;
					case 'g': return Language.CNG;
					case 'h': return Language.CNH;
					case 'i': return Language.CNI;
					case 'k': return Language.CNK;
					case 'l': return Language.CNL;
					case 'o': return Language.CNO;
					case 's': return Language.CNS;
					case 't': return Language.CNT;
					case 'u': return Language.CNU;
					case 'w': return Language.CNW;
					case 'x': return Language.CNX;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_cp(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.CPA;
					case 'b': return Language.CPB;
					case 'c': return Language.CPC;
					case 'e': return Language.CPE;
					case 'f': return Language.CPF;
					case 'g': return Language.CPG;
					case 'i': return Language.CPI;
					case 'n': return Language.CPN;
					case 'o': return Language.CPO;
					case 'p': return Language.CPP;
					case 's': return Language.CPS;
					case 'u': return Language.CPU;
					case 'x': return Language.CPX;
					case 'y': return Language.CPY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_cq(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'd': return Language.CQD;
					case 'u': return Language.QUH;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ct(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.CTA;
					case 'c': return Language.CTC;
					case 'd': return Language.CTD;
					case 'e': return Language.CTE;
					case 'g': return Language.CTG;
					case 'h': return Language.CTH;
					case 'l': return Language.CTL;
					case 'm': return Language.CTM;
					case 'n': return Language.CTN;
					case 'o': return Language.CTO;
					case 'p': return Language.CTP;
					case 's': return Language.CTS;
					case 't': return Language.CTT;
					case 'u': return Language.CTU;
					case 'z': return Language.CTZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_cw(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.CWA;
					case 'b': return Language.CWB;
					case 'd': return Language.CWD;
					case 'e': return Language.CWE;
					case 'g': return Language.CWG;
					case 't': return Language.CWT;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_cz(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'h': return Language.CZH;
					case 'k': return Language.CZK;
					case 'n': return Language.CZN;
					case 'o': return Language.CZO;
					case 't': return Language.CZT;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_d(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return tryParseFromLanguage_da(text, ref offset);
					case 'e': return tryParseFromLanguage_de(text, ref offset);
					case 'v': return tryParseFromLanguage_dv(text, ref offset);
					case 'z': return tryParseFromLanguage_dz(text, ref offset);
					case 'b': return tryParseFromLanguage_db(text, ref offset);
					case 'c': return tryParseFromLanguage_dc(text, ref offset);
					case 'd': return tryParseFromLanguage_dd(text, ref offset);
					case 'g': return tryParseFromLanguage_dg(text, ref offset);
					case 'h': return tryParseFromLanguage_dh(text, ref offset);
					case 'i': return tryParseFromLanguage_di(text, ref offset);
					case 'j': return tryParseFromLanguage_dj(text, ref offset);
					case 'k': return tryParseFromLanguage_dk(text, ref offset);
					case 'l': return tryParseFromLanguage_dl(text, ref offset);
					case 'm': return tryParseFromLanguage_dm(text, ref offset);
					case 'n': return tryParseFromLanguage_dn(text, ref offset);
					case 'o': return tryParseFromLanguage_do(text, ref offset);
					case 'p': return tryParseFromLanguage_dp(text, ref offset);
					case 'r': return tryParseFromLanguage_dr(text, ref offset);
					case 's': return tryParseFromLanguage_ds(text, ref offset);
					case 't': return tryParseFromLanguage_dt(text, ref offset);
					case 'u': return tryParseFromLanguage_du(text, ref offset);
					case 'w': return tryParseFromLanguage_dw(text, ref offset);
					case 'y': return tryParseFromLanguage_dy(text, ref offset);
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_da(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.DAA;
					case 'c': return Language.DAC;
					case 'd': return Language.DAD;
					case 'e': return Language.DAE;
					case 'f': return Language.DAF;
					case 'g': return Language.DAG;
					case 'h': return Language.DAH;
					case 'i': return Language.DAI;
					case 'j': return Language.DAJ;
					case 'k': return Language.DAK;
					case 'l': return Language.DAL;
					case 'm': return Language.DAM;
					case 'o': return Language.DAO;
					case 'p': return Language.DAP;
					case 'q': return Language.DAQ;
					case 'r': return Language.DAR;
					case 's': return Language.DAS;
					case 'u': return Language.DAU;
					case 'v': return Language.DAV;
					case 'w': return Language.DAW;
					case 'x': return Language.DAX;
					case 'y': return Language.DAY;
					case 'z': return Language.DAZ;
				}
				offset--;
			}
			return Language.DA;
		}

		private static Language? tryParseFromLanguage_de(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'c': return Language.DEC;
					case 'd': return Language.DED;
					case 'e': return Language.DEE;
					case 'f': return Language.DEF;
					case 'g': return Language.DEG;
					case 'h': return Language.DEH;
					case 'i': return Language.DEI;
					case 'k': return Language.DEK;
					case 'l': return Language.DEL;
					case 'm': return Language.DEM;
					case 'n': return Language.DEN;
					case 'p': return Language.DEP;
					case 'q': return Language.DEQ;
					case 'r': return Language.DER;
					case 's': return Language.DES;
					case 'v': return Language.DEV;
					case 'z': return Language.DEZ;
				}
				offset--;
			}
			return Language.DE;
		}

		private static Language? tryParseFromLanguage_dv(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.DVA;
				}
				offset--;
			}
			return Language.DV;
		}

		private static Language? tryParseFromLanguage_dz(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.DZA;
					case 'd': return Language.DZD;
					case 'e': return Language.DZE;
					case 'g': return Language.DZG;
					case 'l': return Language.DZL;
					case 'n': return Language.DZN;
				}
				offset--;
			}
			return Language.DZ;
		}

		private static Language? tryParseFromLanguage_db(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.DBA;
					case 'b': return Language.DBB;
					case 'd': return Language.DBD;
					case 'e': return Language.DBE;
					case 'f': return Language.DBF;
					case 'g': return Language.DBG;
					case 'i': return Language.DBI;
					case 'j': return Language.DBJ;
					case 'l': return Language.DBL;
					case 'm': return Language.DBM;
					case 'n': return Language.DBN;
					case 'o': return Language.DBO;
					case 'p': return Language.DBP;
					case 'q': return Language.DBQ;
					case 'r': return Language.DBR;
					case 't': return Language.DBT;
					case 'u': return Language.DBU;
					case 'v': return Language.DBV;
					case 'w': return Language.DBW;
					case 'y': return Language.DBY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_dc(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'c': return Language.DCC;
					case 'r': return Language.DCR;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_dd(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.DDA;
					case 'd': return Language.DDD;
					case 'e': return Language.DDE;
					case 'g': return Language.DDG;
					case 'i': return Language.DDI;
					case 'j': return Language.DDJ;
					case 'n': return Language.DDN;
					case 'o': return Language.DDO;
					case 'r': return Language.DDR;
					case 's': return Language.DDS;
					case 'w': return Language.DDW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_dg(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.DGA;
					case 'b': return Language.DGB;
					case 'c': return Language.DGC;
					case 'd': return Language.DGD;
					case 'e': return Language.DGE;
					case 'g': return Language.DGG;
					case 'h': return Language.DGH;
					case 'i': return Language.DGI;
					case 'k': return Language.DGK;
					case 'l': return Language.DGL;
					case 'n': return Language.DGN;
					case 'o': return Language.DGO;
					case 'r': return Language.DGR;
					case 's': return Language.DGS;
					case 't': return Language.DGT;
					case 'u': return Language.DGU;
					case 'w': return Language.DGW;
					case 'x': return Language.DGX;
					case 'z': return Language.DGZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_dh(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.DHA;
					case 'd': return Language.DHD;
					case 'g': return Language.DHG;
					case 'i': return Language.DHI;
					case 'l': return Language.DHL;
					case 'm': return Language.DHM;
					case 'n': return Language.DHN;
					case 'o': return Language.DHO;
					case 'r': return Language.DHR;
					case 's': return Language.DHS;
					case 'u': return Language.DHU;
					case 'v': return Language.DHV;
					case 'w': return Language.DHW;
					case 'x': return Language.DHX;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_di(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.DIA;
					case 'b': return Language.DIB;
					case 'c': return Language.DIC;
					case 'd': return Language.DID;
					case 'f': return Language.DIF;
					case 'g': return Language.DIG;
					case 'h': return Language.DIH;
					case 'i': return Language.DII;
					case 'j': return Language.DIJ;
					case 'k': return Language.DIK;
					case 'l': return Language.DIL;
					case 'm': return Language.DIM;
					case 'n': return Language.DIN;
					case 'o': return Language.DIO;
					case 'p': return Language.DIP;
					case 'q': return Language.DIQ;
					case 'r': return Language.DIR;
					case 's': return Language.DIS;
					case 't': return Language.DIT;
					case 'u': return Language.DIU;
					case 'w': return Language.DIW;
					case 'x': return Language.DIX;
					case 'y': return Language.DIY;
					case 'z': return Language.DIZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_dj(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.DJA;
					case 'b': return Language.DJB;
					case 'c': return Language.DJC;
					case 'd': return Language.DJD;
					case 'e': return Language.DJE;
					case 'f': return Language.DJF;
					case 'i': return Language.DJI;
					case 'j': return Language.DJJ;
					case 'k': return Language.DJK;
					case 'l': return Language.DJL;
					case 'm': return Language.DJM;
					case 'n': return Language.DJN;
					case 'o': return Language.DJO;
					case 'r': return Language.DJR;
					case 'u': return Language.DJU;
					case 'w': return Language.DJW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_dk(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.DKA;
					case 'k': return Language.DKK;
					case 'l': return Language.DKL;
					case 'r': return Language.DKR;
					case 's': return Language.DKS;
					case 'x': return Language.DKX;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_dl(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'g': return Language.DLG;
					case 'k': return Language.DLK;
					case 'm': return Language.DLM;
					case 'n': return Language.DLN;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_dm(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.DMA;
					case 'b': return Language.DMB;
					case 'c': return Language.DMC;
					case 'd': return Language.DMD;
					case 'e': return Language.DME;
					case 'g': return Language.DMG;
					case 'k': return Language.DMK;
					case 'l': return Language.DML;
					case 'm': return Language.DMM;
					case 'n': return Language.DMN;
					case 'o': return Language.DMO;
					case 'r': return Language.DMR;
					case 's': return Language.DMS;
					case 'u': return Language.DMU;
					case 'v': return Language.DMV;
					case 'w': return Language.DMW;
					case 'x': return Language.DMX;
					case 'y': return Language.DMY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_dn(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.DNA;
					case 'd': return Language.DND;
					case 'e': return Language.DNE;
					case 'g': return Language.DNG;
					case 'i': return Language.DNI;
					case 'j': return Language.DNJ;
					case 'k': return Language.DNK;
					case 'n': return Language.DNN;
					case 'r': return Language.DNR;
					case 't': return Language.DNT;
					case 'u': return Language.DNU;
					case 'v': return Language.DNV;
					case 'w': return Language.DNW;
					case 'y': return Language.DNY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_do(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.DOA;
					case 'b': return Language.DOB;
					case 'c': return Language.DOC;
					case 'e': return Language.DOE;
					case 'f': return Language.DOF;
					case 'h': return Language.DOH;
					case 'i': return Language.DOI;
					case 'k': return Language.DOK;
					case 'l': return Language.DOL;
					case 'n': return Language.DON;
					case 'o': return Language.DOO;
					case 'p': return Language.DOP;
					case 'q': return Language.DOQ;
					case 'r': return Language.DOR;
					case 's': return Language.DOS;
					case 't': return Language.DOT;
					case 'v': return Language.DOV;
					case 'w': return Language.DOW;
					case 'x': return Language.DOX;
					case 'y': return Language.DOY;
					case 'z': return Language.DOZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_dp(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'p': return Language.DPP;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_dr(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.DRA;
					case 'b': return Language.DRB;
					case 'c': return Language.DRC;
					case 'd': return Language.DRD;
					case 'e': return Language.DRE;
					case 'g': return Language.DRG;
					case 'h': return Language.KHK;
					case 'i': return Language.DRI;
					case 'l': return Language.DRL;
					case 'n': return Language.DRN;
					case 'o': return Language.DRO;
					case 'q': return Language.DRQ;
					case 'r': return Language.DRR;
					case 's': return Language.DRS;
					case 't': return Language.DRT;
					case 'u': return Language.DRU;
					case 'w': return Language.PRS;
					case 'y': return Language.DRY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ds(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.DSB;
					case 'e': return Language.DSE;
					case 'h': return Language.DSH;
					case 'i': return Language.DSI;
					case 'l': return Language.DSL;
					case 'n': return Language.DSN;
					case 'o': return Language.DSO;
					case 'q': return Language.DSQ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_dt(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.DTA;
					case 'b': return Language.DTB;
					case 'd': return Language.DTD;
					case 'h': return Language.DTH;
					case 'i': return Language.DTI;
					case 'k': return Language.DTK;
					case 'm': return Language.DTM;
					case 'n': return Language.DTN;
					case 'o': return Language.DTO;
					case 'p': return Language.DTP;
					case 'r': return Language.DTR;
					case 's': return Language.DTS;
					case 't': return Language.DTT;
					case 'u': return Language.DTU;
					case 'y': return Language.DTY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_du(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.DUA;
					case 'b': return Language.DUB;
					case 'c': return Language.DUC;
					case 'd': return Language.DUD;
					case 'e': return Language.DUE;
					case 'f': return Language.DUF;
					case 'g': return Language.DUG;
					case 'h': return Language.DUH;
					case 'i': return Language.DUI;
					case 'j': return Language.DUJ;
					case 'k': return Language.DUK;
					case 'l': return Language.DUL;
					case 'm': return Language.DUM;
					case 'n': return Language.DUN;
					case 'o': return Language.DUO;
					case 'p': return Language.DUP;
					case 'q': return Language.DUQ;
					case 'r': return Language.DUR;
					case 's': return Language.DUS;
					case 'u': return Language.DUU;
					case 'v': return Language.DUV;
					case 'w': return Language.DUW;
					case 'x': return Language.DUX;
					case 'y': return Language.DUY;
					case 'z': return Language.DUZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_dw(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.DWA;
					case 'l': return Language.DWL;
					case 'r': return Language.DWR;
					case 's': return Language.DWS;
					case 'u': return Language.DWU;
					case 'w': return Language.DWW;
					case 'y': return Language.DWY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_dy(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.DYA;
					case 'b': return Language.DYB;
					case 'd': return Language.DYD;
					case 'g': return Language.DYG;
					case 'i': return Language.DYI;
					case 'm': return Language.DYM;
					case 'n': return Language.DYN;
					case 'o': return Language.DYO;
					case 'u': return Language.DYU;
					case 'y': return Language.DYY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_e(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'e': return tryParseFromLanguage_ee(text, ref offset);
					case 'l': return tryParseFromLanguage_el(text, ref offset);
					case 'n': return tryParseFromLanguage_en(text, ref offset);
					case 'o': return tryParseFromLanguage_eo(text, ref offset);
					case 's': return tryParseFromLanguage_es(text, ref offset);
					case 't': return tryParseFromLanguage_et(text, ref offset);
					case 'u': return tryParseFromLanguage_eu(text, ref offset);
					case 'a': return tryParseFromLanguage_ea(text, ref offset);
					case 'b': return tryParseFromLanguage_eb(text, ref offset);
					case 'c': return tryParseFromLanguage_ec(text, ref offset);
					case 'f': return tryParseFromLanguage_ef(text, ref offset);
					case 'g': return tryParseFromLanguage_eg(text, ref offset);
					case 'h': return tryParseFromLanguage_eh(text, ref offset);
					case 'i': return tryParseFromLanguage_ei(text, ref offset);
					case 'j': return tryParseFromLanguage_ej(text, ref offset);
					case 'k': return tryParseFromLanguage_ek(text, ref offset);
					case 'm': return tryParseFromLanguage_em(text, ref offset);
					case 'p': return tryParseFromLanguage_ep(text, ref offset);
					case 'r': return tryParseFromLanguage_er(text, ref offset);
					case 'v': return tryParseFromLanguage_ev(text, ref offset);
					case 'w': return tryParseFromLanguage_ew(text, ref offset);
					case 'x': return tryParseFromLanguage_ex(text, ref offset);
					case 'y': return tryParseFromLanguage_ey(text, ref offset);
					case 'z': return tryParseFromLanguage_ez(text, ref offset);
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ee(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'e': return Language.EEE;
				}
				offset--;
			}
			return Language.EE;
		}

		private static Language? tryParseFromLanguage_el(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'e': return Language.ELE;
					case 'h': return Language.ELH;
					case 'i': return Language.ELI;
					case 'k': return Language.ELK;
					case 'm': return Language.ELM;
					case 'o': return Language.ELO;
					case 'p': return Language.ELP;
					case 'u': return Language.ELU;
					case 'x': return Language.ELX;
				}
				offset--;
			}
			return Language.EL;
		}

		private static Language? tryParseFromLanguage_en(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.ENA;
					case 'b': return Language.ENB;
					case 'c': return Language.ENC;
					case 'd': return Language.END;
					case 'f': return Language.ENF;
					case 'h': return Language.ENH;
					case 'l': return Language.ENL;
					case 'm': return Language.ENM;
					case 'n': return Language.ENN;
					case 'o': return Language.ENO;
					case 'q': return Language.ENQ;
					case 'r': return Language.ENR;
					case 'u': return Language.ENU;
					case 'v': return Language.ENV;
					case 'w': return Language.ENW;
					case 'x': return Language.ENX;
				}
				offset--;
			}
			return Language.EN;
		}

		private static Language? tryParseFromLanguage_eo(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 't': return Language.EOT;
				}
				offset--;
			}
			return Language.EO;
		}

		private static Language? tryParseFromLanguage_es(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'e': return Language.ESE;
					case 'g': return Language.ESG;
					case 'h': return Language.ESH;
					case 'i': return Language.ESI;
					case 'k': return Language.ESK;
					case 'l': return Language.ESL;
					case 'm': return Language.ESM;
					case 'n': return Language.ESN;
					case 'o': return Language.ESO;
					case 'q': return Language.ESQ;
					case 's': return Language.ESS;
					case 'u': return Language.ESU;
					case 'x': return Language.ESX;
					case 'y': return Language.ESY;
				}
				offset--;
			}
			return Language.ES;
		}

		private static Language? tryParseFromLanguage_et(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.ETB;
					case 'c': return Language.ETC;
					case 'h': return Language.ETH;
					case 'n': return Language.ETN;
					case 'o': return Language.ETO;
					case 'r': return Language.ETR;
					case 's': return Language.ETS;
					case 't': return Language.ETT;
					case 'u': return Language.ETU;
					case 'x': return Language.ETX;
					case 'z': return Language.ETZ;
				}
				offset--;
			}
			return Language.ET;
		}

		private static Language? tryParseFromLanguage_eu(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'q': return Language.EUQ;
				}
				offset--;
			}
			return Language.EU;
		}

		private static Language? tryParseFromLanguage_ea(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.EAA;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_eb(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'g': return Language.EBG;
					case 'k': return Language.EBK;
					case 'o': return Language.EBO;
					case 'r': return Language.EBR;
					case 'u': return Language.EBU;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ec(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'r': return Language.ECR;
					case 's': return Language.ECS;
					case 'y': return Language.ECY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ef(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.EFA;
					case 'e': return Language.EFE;
					case 'i': return Language.EFI;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_eg(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.EGA;
					case 'l': return Language.EGL;
					case 'o': return Language.EGO;
					case 'x': return Language.EGX;
					case 'y': return Language.EGY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_eh(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'u': return Language.EHU;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ei(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'p': return Language.EIP;
					case 't': return Language.EIT;
					case 'v': return Language.EIV;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ej(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.EJA;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ek(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.EKA;
					case 'c': return Language.EKC;
					case 'e': return Language.EKE;
					case 'g': return Language.EKG;
					case 'i': return Language.EKI;
					case 'k': return Language.EKK;
					case 'l': return Language.EKL;
					case 'm': return Language.EKM;
					case 'o': return Language.EKO;
					case 'p': return Language.EKP;
					case 'r': return Language.EKR;
					case 'y': return Language.EKY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_em(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.EMA;
					case 'b': return Language.EMB;
					case 'e': return Language.EME;
					case 'g': return Language.EMG;
					case 'i': return Language.EMI;
					case 'k': return Language.EMK;
					case 'm': return Language.EMM;
					case 'n': return Language.EMN;
					case 'o': return Language.EMO;
					case 'p': return Language.EMP;
					case 's': return Language.EMS;
					case 'u': return Language.EMU;
					case 'w': return Language.EMW;
					case 'x': return Language.EMX;
					case 'y': return Language.EMY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ep(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'i': return Language.EPI;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_er(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.ERA;
					case 'g': return Language.ERG;
					case 'h': return Language.ERH;
					case 'i': return Language.ERI;
					case 'k': return Language.ERK;
					case 'o': return Language.ERO;
					case 'r': return Language.ERR;
					case 's': return Language.ERS;
					case 't': return Language.ERT;
					case 'w': return Language.ERW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ev(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'e': return Language.EVE;
					case 'h': return Language.EVH;
					case 'n': return Language.EVN;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ew(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'o': return Language.EWO;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ex(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 't': return Language.EXT;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ey(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.EYA;
					case 'o': return Language.EYO;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ez(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.EZA;
					case 'e': return Language.EZE;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_f(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return tryParseFromLanguage_fa(text, ref offset);
					case 'f': return tryParseFromLanguage_ff(text, ref offset);
					case 'i': return tryParseFromLanguage_fi(text, ref offset);
					case 'j': return Language.FJ;
					case 'o': return tryParseFromLanguage_fo(text, ref offset);
					case 'r': return tryParseFromLanguage_fr(text, ref offset);
					case 'y': return Language.FY;
					case 'b': return tryParseFromLanguage_fb(text, ref offset);
					case 'c': return tryParseFromLanguage_fc(text, ref offset);
					case 'e': return tryParseFromLanguage_fe(text, ref offset);
					case 'g': return tryParseFromLanguage_fg(text, ref offset);
					case 'k': return tryParseFromLanguage_fk(text, ref offset);
					case 'l': return tryParseFromLanguage_fl(text, ref offset);
					case 'm': return tryParseFromLanguage_fm(text, ref offset);
					case 'n': return tryParseFromLanguage_fn(text, ref offset);
					case 'p': return tryParseFromLanguage_fp(text, ref offset);
					case 'q': return tryParseFromLanguage_fq(text, ref offset);
					case 's': return tryParseFromLanguage_fs(text, ref offset);
					case 'u': return tryParseFromLanguage_fu(text, ref offset);
					case 'v': return tryParseFromLanguage_fv(text, ref offset);
					case 'w': return tryParseFromLanguage_fw(text, ref offset);
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_fa(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.FAA;
					case 'b': return Language.FAB;
					case 'd': return Language.FAD;
					case 'f': return Language.FAF;
					case 'g': return Language.FAG;
					case 'h': return Language.FAH;
					case 'i': return Language.FAI;
					case 'j': return Language.FAJ;
					case 'k': return Language.FAK;
					case 'l': return Language.FAL;
					case 'm': return Language.FAM;
					case 'n': return Language.FAN;
					case 'p': return Language.FAP;
					case 'r': return Language.FAR;
					case 't': return Language.FAT;
					case 'u': return Language.FAU;
					case 'x': return Language.FAX;
					case 'y': return Language.FAY;
					case 'z': return Language.FAZ;
				}
				offset--;
			}
			return Language.FA;
		}

		private static Language? tryParseFromLanguage_ff(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'i': return Language.FFI;
					case 'm': return Language.FFM;
				}
				offset--;
			}
			return Language.FF;
		}

		private static Language? tryParseFromLanguage_fi(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.FIA;
					case 'e': return Language.FIE;
					case 'l': return Language.FIL;
					case 'p': return Language.FIP;
					case 'r': return Language.FIR;
					case 't': return Language.FIT;
					case 'u': return Language.FIU;
					case 'w': return Language.FIW;
				}
				offset--;
			}
			return Language.FI;
		}

		private static Language? tryParseFromLanguage_fo(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'd': return Language.FOD;
					case 'i': return Language.FOI;
					case 'm': return Language.FOM;
					case 'n': return Language.FON;
					case 'r': return Language.FOR;
					case 's': return Language.FOS;
					case 'x': return Language.FOX;
				}
				offset--;
			}
			return Language.FO;
		}

		private static Language? tryParseFromLanguage_fr(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'c': return Language.FRC;
					case 'd': return Language.FRD;
					case 'k': return Language.FRK;
					case 'm': return Language.FRM;
					case 'o': return Language.FRO;
					case 'p': return Language.FRP;
					case 'q': return Language.FRQ;
					case 'r': return Language.FRR;
					case 's': return Language.FRS;
					case 't': return Language.FRT;
				}
				offset--;
			}
			return Language.FR;
		}

		private static Language? tryParseFromLanguage_fb(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'l': return Language.FBL;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_fc(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 's': return Language.FCS;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_fe(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'r': return Language.FER;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_fg(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'r': return Language.FGR;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_fk(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'k': return Language.FKK;
					case 'v': return Language.FKV;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_fl(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.FLA;
					case 'h': return Language.FLH;
					case 'i': return Language.FLI;
					case 'l': return Language.FLL;
					case 'n': return Language.FLN;
					case 'r': return Language.FLR;
					case 'y': return Language.FLY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_fm(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'p': return Language.FMP;
					case 'u': return Language.FMU;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_fn(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.FNB;
					case 'g': return Language.FNG;
					case 'i': return Language.FNI;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_fp(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'e': return Language.FPE;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_fq(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 's': return Language.FQS;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_fs(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'e': return Language.FSE;
					case 'l': return Language.FSL;
					case 's': return Language.FSS;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_fu(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.FUB;
					case 'c': return Language.FUC;
					case 'd': return Language.FUD;
					case 'e': return Language.FUE;
					case 'f': return Language.FUF;
					case 'h': return Language.FUH;
					case 'i': return Language.FUI;
					case 'j': return Language.FUJ;
					case 'm': return Language.FUM;
					case 'n': return Language.FUN;
					case 'q': return Language.FUQ;
					case 'r': return Language.FUR;
					case 't': return Language.FUT;
					case 'u': return Language.FUU;
					case 'v': return Language.FUV;
					case 'y': return Language.FUY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_fv(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'r': return Language.FVR;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_fw(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.FWA;
					case 'e': return Language.FWE;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_g(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return tryParseFromLanguage_ga(text, ref offset);
					case 'd': return tryParseFromLanguage_gd(text, ref offset);
					case 'l': return tryParseFromLanguage_gl(text, ref offset);
					case 'n': return tryParseFromLanguage_gn(text, ref offset);
					case 'u': return tryParseFromLanguage_gu(text, ref offset);
					case 'v': return tryParseFromLanguage_gv(text, ref offset);
					case 'b': return tryParseFromLanguage_gb(text, ref offset);
					case 'c': return tryParseFromLanguage_gc(text, ref offset);
					case 'e': return tryParseFromLanguage_ge(text, ref offset);
					case 'f': return tryParseFromLanguage_gf(text, ref offset);
					case 'g': return tryParseFromLanguage_gg(text, ref offset);
					case 'h': return tryParseFromLanguage_gh(text, ref offset);
					case 'i': return tryParseFromLanguage_gi(text, ref offset);
					case 'j': return tryParseFromLanguage_gj(text, ref offset);
					case 'k': return tryParseFromLanguage_gk(text, ref offset);
					case 'm': return tryParseFromLanguage_gm(text, ref offset);
					case 'o': return tryParseFromLanguage_go(text, ref offset);
					case 'p': return tryParseFromLanguage_gp(text, ref offset);
					case 'q': return tryParseFromLanguage_gq(text, ref offset);
					case 'r': return tryParseFromLanguage_gr(text, ref offset);
					case 's': return tryParseFromLanguage_gs(text, ref offset);
					case 't': return tryParseFromLanguage_gt(text, ref offset);
					case 'w': return tryParseFromLanguage_gw(text, ref offset);
					case 'x': return tryParseFromLanguage_gx(text, ref offset);
					case 'y': return tryParseFromLanguage_gy(text, ref offset);
					case 'z': return tryParseFromLanguage_gz(text, ref offset);
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ga(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.GAA;
					case 'b': return Language.GAB;
					case 'c': return Language.GAC;
					case 'd': return Language.GAD;
					case 'e': return Language.GAE;
					case 'f': return Language.GAF;
					case 'g': return Language.GAG;
					case 'h': return Language.GAH;
					case 'i': return Language.GAI;
					case 'j': return Language.GAJ;
					case 'k': return Language.GAK;
					case 'l': return Language.GAL;
					case 'm': return Language.GAM;
					case 'n': return Language.GAN;
					case 'o': return Language.GAO;
					case 'p': return Language.GAP;
					case 'q': return Language.GAQ;
					case 'r': return Language.GAR;
					case 's': return Language.GAS;
					case 't': return Language.GAT;
					case 'u': return Language.GAU;
					case 'v': return Language.DEV;
					case 'w': return Language.GAW;
					case 'x': return Language.GAX;
					case 'y': return Language.GAY;
					case 'z': return Language.GAZ;
				}
				offset--;
			}
			return Language.GA;
		}

		private static Language? tryParseFromLanguage_gd(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.GDA;
					case 'b': return Language.GDB;
					case 'c': return Language.GDC;
					case 'd': return Language.GDD;
					case 'e': return Language.GDE;
					case 'f': return Language.GDF;
					case 'g': return Language.GDG;
					case 'h': return Language.GDH;
					case 'i': return Language.GDI;
					case 'j': return Language.GDJ;
					case 'k': return Language.GDK;
					case 'l': return Language.GDL;
					case 'm': return Language.GDM;
					case 'n': return Language.GDN;
					case 'o': return Language.GDO;
					case 'q': return Language.GDQ;
					case 'r': return Language.GDR;
					case 's': return Language.GDS;
					case 't': return Language.GDT;
					case 'u': return Language.GDU;
					case 'x': return Language.GDX;
				}
				offset--;
			}
			return Language.GD;
		}

		private static Language? tryParseFromLanguage_gl(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'c': return Language.GLC;
					case 'd': return Language.GLD;
					case 'h': return Language.GLH;
					case 'i': return Language.GLI;
					case 'j': return Language.GLJ;
					case 'k': return Language.GLK;
					case 'l': return Language.GLL;
					case 'o': return Language.GLO;
					case 'r': return Language.GLR;
					case 'u': return Language.GLU;
					case 'w': return Language.GLW;
					case 'y': return Language.GLY;
				}
				offset--;
			}
			return Language.GL;
		}

		private static Language? tryParseFromLanguage_gn(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.GNA;
					case 'b': return Language.GNB;
					case 'c': return Language.GNC;
					case 'd': return Language.GND;
					case 'e': return Language.GNE;
					case 'g': return Language.GNG;
					case 'h': return Language.GNH;
					case 'i': return Language.GNI;
					case 'k': return Language.GNK;
					case 'l': return Language.GNL;
					case 'm': return Language.GNM;
					case 'n': return Language.GNN;
					case 'o': return Language.GNO;
					case 'q': return Language.GNQ;
					case 'r': return Language.GNR;
					case 't': return Language.GNT;
					case 'u': return Language.GNU;
					case 'w': return Language.GNW;
					case 'z': return Language.GNZ;
				}
				offset--;
			}
			return Language.GN;
		}

		private static Language? tryParseFromLanguage_gu(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.GUA;
					case 'b': return Language.GUB;
					case 'c': return Language.GUC;
					case 'd': return Language.GUD;
					case 'e': return Language.GUE;
					case 'f': return Language.GUF;
					case 'g': return Language.GUG;
					case 'h': return Language.GUH;
					case 'i': return Language.GUI;
					case 'k': return Language.GUK;
					case 'l': return Language.GUL;
					case 'm': return Language.GUM;
					case 'n': return Language.GUN;
					case 'o': return Language.GUO;
					case 'p': return Language.GUP;
					case 'q': return Language.GUQ;
					case 'r': return Language.GUR;
					case 's': return Language.GUS;
					case 't': return Language.GUT;
					case 'u': return Language.GUU;
					case 'v': return Language.DUZ;
					case 'w': return Language.GUW;
					case 'x': return Language.GUX;
					case 'z': return Language.GUZ;
				}
				offset--;
			}
			return Language.GU;
		}

		private static Language? tryParseFromLanguage_gv(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.GVA;
					case 'c': return Language.GVC;
					case 'e': return Language.GVE;
					case 'f': return Language.GVF;
					case 'j': return Language.GVJ;
					case 'l': return Language.GVL;
					case 'm': return Language.GVM;
					case 'n': return Language.GVN;
					case 'o': return Language.GVO;
					case 'p': return Language.GVP;
					case 'r': return Language.GVR;
					case 's': return Language.GVS;
					case 'y': return Language.GVY;
				}
				offset--;
			}
			return Language.GV;
		}

		private static Language? tryParseFromLanguage_gb(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.GBA;
					case 'b': return Language.GBB;
					case 'c': return Language.GBC;
					case 'd': return Language.GBD;
					case 'e': return Language.GBE;
					case 'f': return Language.GBF;
					case 'g': return Language.GBG;
					case 'h': return Language.GBH;
					case 'i': return Language.GBI;
					case 'j': return Language.GBJ;
					case 'k': return Language.GBK;
					case 'l': return Language.GBL;
					case 'm': return Language.GBM;
					case 'n': return Language.GBN;
					case 'o': return Language.GBO;
					case 'p': return Language.GBP;
					case 'q': return Language.GBQ;
					case 'r': return Language.GBR;
					case 's': return Language.GBS;
					case 'u': return Language.GBU;
					case 'v': return Language.GBV;
					case 'w': return Language.GBW;
					case 'x': return Language.GBX;
					case 'y': return Language.GBY;
					case 'z': return Language.GBZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_gc(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'c': return Language.GCC;
					case 'd': return Language.GCD;
					case 'e': return Language.GCE;
					case 'f': return Language.GCF;
					case 'l': return Language.GCL;
					case 'n': return Language.GCN;
					case 'r': return Language.GCR;
					case 't': return Language.GCT;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ge(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.GEA;
					case 'b': return Language.GEB;
					case 'c': return Language.GEC;
					case 'd': return Language.GED;
					case 'g': return Language.GEG;
					case 'h': return Language.GEH;
					case 'i': return Language.GEI;
					case 'j': return Language.GEJ;
					case 'k': return Language.GEK;
					case 'l': return Language.GEL;
					case 'm': return Language.GEM;
					case 'q': return Language.GEQ;
					case 's': return Language.GES;
					case 'v': return Language.GEV;
					case 'w': return Language.GEW;
					case 'x': return Language.GEX;
					case 'y': return Language.GEY;
					case 'z': return Language.GEZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_gf(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'k': return Language.GFK;
					case 't': return Language.GFT;
					case 'x': return Language.VAJ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_gg(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.GGA;
					case 'b': return Language.GGB;
					case 'd': return Language.GGD;
					case 'e': return Language.GGE;
					case 'g': return Language.GGG;
					case 'k': return Language.GGK;
					case 'l': return Language.GGL;
					case 'n': return Language.GVR;
					case 'o': return Language.GGO;
					case 'r': return Language.GGR;
					case 't': return Language.GGT;
					case 'u': return Language.GGU;
					case 'w': return Language.GGW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_gh(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.GHA;
					case 'c': return Language.GHC;
					case 'e': return Language.GHE;
					case 'h': return Language.GHH;
					case 'k': return Language.GHK;
					case 'l': return Language.GHL;
					case 'n': return Language.GHN;
					case 'o': return Language.GHO;
					case 'r': return Language.GHR;
					case 's': return Language.GHS;
					case 't': return Language.GHT;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_gi(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.GIA;
					case 'b': return Language.GIB;
					case 'c': return Language.GIC;
					case 'd': return Language.GID;
					case 'g': return Language.GIG;
					case 'h': return Language.GIH;
					case 'l': return Language.GIL;
					case 'm': return Language.GIM;
					case 'n': return Language.GIN;
					case 'o': return Language.GIO;
					case 'p': return Language.GIP;
					case 'q': return Language.GIQ;
					case 'r': return Language.GIR;
					case 's': return Language.GIS;
					case 't': return Language.GIT;
					case 'u': return Language.GIU;
					case 'w': return Language.GIW;
					case 'x': return Language.GIX;
					case 'y': return Language.GIY;
					case 'z': return Language.GIZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_gj(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'i': return Language.GJI;
					case 'k': return Language.GJK;
					case 'm': return Language.GJM;
					case 'n': return Language.GJN;
					case 'r': return Language.GJR;
					case 'u': return Language.GJU;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_gk(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.GKA;
					case 'e': return Language.GKE;
					case 'n': return Language.GKN;
					case 'o': return Language.GKO;
					case 'p': return Language.GKP;
					case 'u': return Language.GKU;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_gm(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.GMA;
					case 'b': return Language.GMB;
					case 'd': return Language.GMD;
					case 'e': return Language.GME;
					case 'g': return Language.GMG;
					case 'h': return Language.GMH;
					case 'l': return Language.GML;
					case 'm': return Language.GMM;
					case 'n': return Language.GMN;
					case 'q': return Language.GMQ;
					case 'u': return Language.GMU;
					case 'v': return Language.GMV;
					case 'w': return Language.GMW;
					case 'x': return Language.GMX;
					case 'y': return Language.GMY;
					case 'z': return Language.GMZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_go(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.GOA;
					case 'b': return Language.GOB;
					case 'c': return Language.GOC;
					case 'd': return Language.GOD;
					case 'e': return Language.GOE;
					case 'f': return Language.GOF;
					case 'g': return Language.GOG;
					case 'h': return Language.GOH;
					case 'i': return Language.GOI;
					case 'j': return Language.GOJ;
					case 'k': return Language.GOK;
					case 'l': return Language.GOL;
					case 'm': return Language.GOM;
					case 'n': return Language.GON;
					case 'o': return Language.GOO;
					case 'p': return Language.GOP;
					case 'q': return Language.GOQ;
					case 'r': return Language.GOR;
					case 's': return Language.GOS;
					case 't': return Language.GOT;
					case 'u': return Language.GOU;
					case 'w': return Language.GOW;
					case 'x': return Language.GOX;
					case 'y': return Language.GOY;
					case 'z': return Language.GOZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_gp(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.GPA;
					case 'e': return Language.GPE;
					case 'n': return Language.GPN;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_gq(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.GQA;
					case 'i': return Language.GQI;
					case 'n': return Language.GQN;
					case 'r': return Language.GQR;
					case 'u': return Language.GQU;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_gr(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.GRA;
					case 'b': return Language.GRB;
					case 'c': return Language.GRC;
					case 'd': return Language.GRD;
					case 'g': return Language.GRG;
					case 'h': return Language.GRH;
					case 'i': return Language.GRI;
					case 'j': return Language.GRJ;
					case 'k': return Language.GRK;
					case 'm': return Language.GRM;
					case 'o': return Language.GRO;
					case 'q': return Language.GRQ;
					case 'r': return Language.GRR;
					case 's': return Language.GRS;
					case 't': return Language.GRT;
					case 'u': return Language.GRU;
					case 'v': return Language.GRV;
					case 'w': return Language.GRW;
					case 'x': return Language.GRX;
					case 'y': return Language.GRY;
					case 'z': return Language.GRZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_gs(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'e': return Language.GSE;
					case 'g': return Language.GSG;
					case 'l': return Language.GSL;
					case 'm': return Language.GSM;
					case 'n': return Language.GSN;
					case 'o': return Language.GSO;
					case 'p': return Language.GSP;
					case 's': return Language.GSS;
					case 'w': return Language.GSW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_gt(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.GTA;
					case 'i': return Language.NYC;
					case 'u': return Language.GTU;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_gw(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.GWA;
					case 'b': return Language.GWB;
					case 'c': return Language.GWC;
					case 'd': return Language.GWD;
					case 'e': return Language.GWE;
					case 'f': return Language.GWF;
					case 'g': return Language.GWG;
					case 'i': return Language.GWI;
					case 'j': return Language.GWJ;
					case 'm': return Language.GWM;
					case 'n': return Language.GWN;
					case 'r': return Language.GWR;
					case 't': return Language.GWT;
					case 'u': return Language.GWU;
					case 'w': return Language.GWW;
					case 'x': return Language.GWX;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_gx(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'x': return Language.GXX;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_gy(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.GYA;
					case 'b': return Language.GYB;
					case 'd': return Language.GYD;
					case 'e': return Language.GYE;
					case 'f': return Language.GYF;
					case 'g': return Language.GYG;
					case 'i': return Language.GYI;
					case 'l': return Language.GYL;
					case 'm': return Language.GYM;
					case 'n': return Language.GYN;
					case 'r': return Language.GYR;
					case 'y': return Language.GYY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_gz(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.GZA;
					case 'i': return Language.GZI;
					case 'n': return Language.GZN;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_h(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return tryParseFromLanguage_ha(text, ref offset);
					case 'e': return tryParseFromLanguage_he(text, ref offset);
					case 'i': return tryParseFromLanguage_hi(text, ref offset);
					case 'o': return tryParseFromLanguage_ho(text, ref offset);
					case 'r': return tryParseFromLanguage_hr(text, ref offset);
					case 't': return tryParseFromLanguage_ht(text, ref offset);
					case 'u': return tryParseFromLanguage_hu(text, ref offset);
					case 'y': return tryParseFromLanguage_hy(text, ref offset);
					case 'z': return Language.HZ;
					case 'b': return tryParseFromLanguage_hb(text, ref offset);
					case 'c': return tryParseFromLanguage_hc(text, ref offset);
					case 'd': return tryParseFromLanguage_hd(text, ref offset);
					case 'g': return tryParseFromLanguage_hg(text, ref offset);
					case 'h': return tryParseFromLanguage_hh(text, ref offset);
					case 'j': return tryParseFromLanguage_hj(text, ref offset);
					case 'k': return tryParseFromLanguage_hk(text, ref offset);
					case 'l': return tryParseFromLanguage_hl(text, ref offset);
					case 'm': return tryParseFromLanguage_hm(text, ref offset);
					case 'n': return tryParseFromLanguage_hn(text, ref offset);
					case 'p': return tryParseFromLanguage_hp(text, ref offset);
					case 's': return tryParseFromLanguage_hs(text, ref offset);
					case 'v': return tryParseFromLanguage_hv(text, ref offset);
					case 'w': return tryParseFromLanguage_hw(text, ref offset);
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ha(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.HAA;
					case 'b': return Language.HAB;
					case 'c': return Language.HAC;
					case 'd': return Language.HAD;
					case 'e': return Language.HAE;
					case 'f': return Language.HAF;
					case 'g': return Language.HAG;
					case 'h': return Language.HAH;
					case 'i': return Language.HAI;
					case 'j': return Language.HAJ;
					case 'k': return Language.HAK;
					case 'l': return Language.HAL;
					case 'm': return Language.HAM;
					case 'n': return Language.HAN;
					case 'o': return Language.HAO;
					case 'p': return Language.HAP;
					case 'q': return Language.HAQ;
					case 'r': return Language.HAR;
					case 's': return Language.HAS;
					case 'v': return Language.HAV;
					case 'w': return Language.HAW;
					case 'x': return Language.HAX;
					case 'y': return Language.HAY;
					case 'z': return Language.HAZ;
				}
				offset--;
			}
			return Language.HA;
		}

		private static Language? tryParseFromLanguage_he(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.HEA;
					case 'd': return Language.HED;
					case 'g': return Language.HEG;
					case 'h': return Language.HEH;
					case 'i': return Language.HEI;
					case 'm': return Language.HEM;
				}
				offset--;
			}
			return Language.HE;
		}

		private static Language? tryParseFromLanguage_hi(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.HIA;
					case 'b': return Language.HIB;
					case 'd': return Language.HID;
					case 'f': return Language.HIF;
					case 'g': return Language.HIG;
					case 'h': return Language.HIH;
					case 'i': return Language.HII;
					case 'j': return Language.HIJ;
					case 'k': return Language.HIK;
					case 'l': return Language.HIL;
					case 'm': return Language.HIM;
					case 'o': return Language.HIO;
					case 'r': return Language.HIR;
					case 't': return Language.HIT;
					case 'w': return Language.HIW;
					case 'x': return Language.HIX;
				}
				offset--;
			}
			return Language.HI;
		}

		private static Language? tryParseFromLanguage_ho(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.HOA;
					case 'b': return Language.HOB;
					case 'c': return Language.HOC;
					case 'd': return Language.HOD;
					case 'e': return Language.HOE;
					case 'h': return Language.HOH;
					case 'i': return Language.HOI;
					case 'j': return Language.HOJ;
					case 'k': return Language.HOK;
					case 'l': return Language.HOL;
					case 'm': return Language.HOM;
					case 'o': return Language.HOO;
					case 'p': return Language.HOP;
					case 'r': return Language.HOR;
					case 's': return Language.HOS;
					case 't': return Language.HOT;
					case 'v': return Language.HOV;
					case 'w': return Language.HOW;
					case 'y': return Language.HOY;
					case 'z': return Language.HOZ;
				}
				offset--;
			}
			return Language.HO;
		}

		private static Language? tryParseFromLanguage_hr(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.HRA;
					case 'c': return Language.HRC;
					case 'e': return Language.HRE;
					case 'k': return Language.HRK;
					case 'm': return Language.HRM;
					case 'o': return Language.HRO;
					case 'p': return Language.HRP;
					case 'r': return Language.JAL;
					case 't': return Language.HRT;
					case 'u': return Language.HRU;
					case 'w': return Language.HRW;
					case 'x': return Language.HRX;
					case 'z': return Language.HRZ;
				}
				offset--;
			}
			return Language.HR;
		}

		private static Language? tryParseFromLanguage_ht(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'i': return Language.HTI;
					case 'o': return Language.HTO;
					case 's': return Language.HTS;
					case 'u': return Language.HTU;
					case 'x': return Language.HTX;
				}
				offset--;
			}
			return Language.HT;
		}

		private static Language? tryParseFromLanguage_hu(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.HUB;
					case 'c': return Language.HUC;
					case 'd': return Language.HUD;
					case 'e': return Language.HUE;
					case 'f': return Language.HUF;
					case 'g': return Language.HUG;
					case 'h': return Language.HUH;
					case 'i': return Language.HUI;
					case 'j': return Language.HUJ;
					case 'k': return Language.HUK;
					case 'l': return Language.HUL;
					case 'm': return Language.HUM;
					case 'o': return Language.HUO;
					case 'p': return Language.HUP;
					case 'q': return Language.HUQ;
					case 'r': return Language.HUR;
					case 's': return Language.HUS;
					case 't': return Language.HUT;
					case 'u': return Language.HUU;
					case 'v': return Language.HUV;
					case 'w': return Language.HUW;
					case 'x': return Language.HUX;
					case 'y': return Language.HUY;
					case 'z': return Language.HUZ;
				}
				offset--;
			}
			return Language.HU;
		}

		private static Language? tryParseFromLanguage_hy(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.HYA;
					case 'x': return Language.HYX;
				}
				offset--;
			}
			return Language.HY;
		}

		private static Language? tryParseFromLanguage_hb(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.HBA;
					case 'b': return Language.HBB;
					case 'n': return Language.HBN;
					case 'o': return Language.HBO;
					case 'u': return Language.HBU;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_hc(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.HCA;
					case 'h': return Language.HCH;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_hd(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'n': return Language.HDN;
					case 's': return Language.HDS;
					case 'y': return Language.HDY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_hg(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'm': return Language.HGM;
					case 'w': return Language.HGW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_hh(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'i': return Language.HHI;
					case 'r': return Language.HHR;
					case 'y': return Language.HHY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_hj(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'i': return Language.HJI;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_hk(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.HKA;
					case 'e': return Language.HKE;
					case 'k': return Language.HKK;
					case 's': return Language.HKS;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_hl(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.HLA;
					case 'b': return Language.HLB;
					case 'd': return Language.HLD;
					case 'e': return Language.HLE;
					case 't': return Language.HLT;
					case 'u': return Language.HLU;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_hm(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.HMA;
					case 'b': return Language.HMB;
					case 'c': return Language.HMC;
					case 'd': return Language.HMD;
					case 'e': return Language.HME;
					case 'f': return Language.HMF;
					case 'g': return Language.HMG;
					case 'h': return Language.HMH;
					case 'i': return Language.HMI;
					case 'j': return Language.HMJ;
					case 'k': return Language.HMK;
					case 'l': return Language.HML;
					case 'm': return Language.HMM;
					case 'n': return Language.HMN;
					case 'p': return Language.HMP;
					case 'q': return Language.HMQ;
					case 'r': return Language.HMR;
					case 's': return Language.HMS;
					case 't': return Language.HMT;
					case 'u': return Language.HMU;
					case 'v': return Language.HMV;
					case 'w': return Language.HMW;
					case 'x': return Language.HMX;
					case 'y': return Language.HMY;
					case 'z': return Language.HMZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_hn(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.HNA;
					case 'd': return Language.HND;
					case 'e': return Language.HNE;
					case 'h': return Language.HNH;
					case 'i': return Language.HNI;
					case 'j': return Language.HNJ;
					case 'n': return Language.HNN;
					case 'o': return Language.HNO;
					case 's': return Language.HNS;
					case 'u': return Language.HNU;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_hp(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'o': return Language.HPO;
					case 's': return Language.HPS;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_hs(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.HSB;
					case 'h': return Language.HSH;
					case 'l': return Language.HSL;
					case 'n': return Language.HSN;
					case 's': return Language.HSS;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_hv(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'c': return Language.HVC;
					case 'e': return Language.HVE;
					case 'k': return Language.HVK;
					case 'n': return Language.HVN;
					case 'v': return Language.HVV;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_hw(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.HWA;
					case 'c': return Language.HWC;
					case 'o': return Language.HWO;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_i(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return tryParseFromLanguage_ia(text, ref offset);
					case 'd': return tryParseFromLanguage_id(text, ref offset);
					case 'e': return Language.IE;
					case 'g': return tryParseFromLanguage_ig(text, ref offset);
					case 'i': return tryParseFromLanguage_ii(text, ref offset);
					case 'k': return tryParseFromLanguage_ik(text, ref offset);
					case 'n': return tryParseFromLanguage_in(text, ref offset);
					case 'o': return tryParseFromLanguage_io(text, ref offset);
					case 's': return tryParseFromLanguage_is(text, ref offset);
					case 't': return tryParseFromLanguage_it(text, ref offset);
					case 'u': return tryParseFromLanguage_iu(text, ref offset);
					case 'w': return tryParseFromLanguage_iw(text, ref offset);
					case 'b': return tryParseFromLanguage_ib(text, ref offset);
					case 'c': return tryParseFromLanguage_ic(text, ref offset);
					case 'f': return tryParseFromLanguage_if(text, ref offset);
					case 'h': return tryParseFromLanguage_ih(text, ref offset);
					case 'j': return tryParseFromLanguage_ij(text, ref offset);
					case 'l': return tryParseFromLanguage_il(text, ref offset);
					case 'm': return tryParseFromLanguage_im(text, ref offset);
					case 'p': return tryParseFromLanguage_ip(text, ref offset);
					case 'q': return tryParseFromLanguage_iq(text, ref offset);
					case 'r': return tryParseFromLanguage_ir(text, ref offset);
					case 'v': return tryParseFromLanguage_iv(text, ref offset);
					case 'x': return tryParseFromLanguage_ix(text, ref offset);
					case 'y': return tryParseFromLanguage_iy(text, ref offset);
					case 'z': return tryParseFromLanguage_iz(text, ref offset);
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ia(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'i': return Language.IAI;
					case 'n': return Language.IAN;
					case 'p': return Language.IAP;
					case 'r': return Language.IAR;
				}
				offset--;
			}
			return Language.IA;
		}

		private static Language? tryParseFromLanguage_id(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.IDA;
					case 'b': return Language.IDB;
					case 'c': return Language.IDC;
					case 'd': return Language.IDD;
					case 'e': return Language.IDE;
					case 'i': return Language.IDI;
					case 'r': return Language.IDR;
					case 's': return Language.IDS;
					case 't': return Language.IDT;
					case 'u': return Language.IDU;
				}
				offset--;
			}
			return Language.ID;
		}

		private static Language? tryParseFromLanguage_ig(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.IGB;
					case 'e': return Language.IGE;
					case 'g': return Language.IGG;
					case 'l': return Language.IGL;
					case 'm': return Language.IGM;
					case 'n': return Language.IGN;
					case 'o': return Language.IGO;
					case 's': return Language.IGS;
					case 'w': return Language.IGW;
				}
				offset--;
			}
			return Language.IG;
		}

		private static Language? tryParseFromLanguage_ii(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'n': return Language.IIN;
					case 'r': return Language.IIR;
				}
				offset--;
			}
			return Language.II;
		}

		private static Language? tryParseFromLanguage_ik(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'e': return Language.IKE;
					case 'i': return Language.IKI;
					case 'k': return Language.IKK;
					case 'l': return Language.IKL;
					case 'o': return Language.IKO;
					case 'p': return Language.IKP;
					case 'r': return Language.IKR;
					case 's': return Language.IKS;
					case 't': return Language.IKT;
					case 'v': return Language.IKV;
					case 'w': return Language.IKW;
					case 'x': return Language.IKX;
					case 'z': return Language.IKZ;
				}
				offset--;
			}
			return Language.IK;
		}

		private static Language? tryParseFromLanguage_in(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.INB;
					case 'c': return Language.INC;
					case 'e': return Language.INE;
					case 'g': return Language.ING;
					case 'h': return Language.INH;
					case 'j': return Language.INJ;
					case 'l': return Language.INL;
					case 'm': return Language.INM;
					case 'n': return Language.INN;
					case 'o': return Language.INO;
					case 'p': return Language.INP;
					case 's': return Language.INS;
					case 't': return Language.INT;
					case 'z': return Language.INZ;
				}
				offset--;
			}
			return Language.ID;
		}

		private static Language? tryParseFromLanguage_io(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'r': return Language.IOR;
					case 'u': return Language.IOU;
					case 'w': return Language.IOW;
				}
				offset--;
			}
			return Language.IO;
		}

		private static Language? tryParseFromLanguage_is(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.ISA;
					case 'c': return Language.ISC;
					case 'd': return Language.ISD;
					case 'e': return Language.ISE;
					case 'g': return Language.ISG;
					case 'h': return Language.ISH;
					case 'i': return Language.ISI;
					case 'k': return Language.ISK;
					case 'm': return Language.ISM;
					case 'n': return Language.ISN;
					case 'o': return Language.ISO;
					case 'r': return Language.ISR;
					case 't': return Language.IST;
					case 'u': return Language.ISU;
				}
				offset--;
			}
			return Language.IS;
		}

		private static Language? tryParseFromLanguage_it(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.ITB;
					case 'c': return Language.ITC;
					case 'd': return Language.ITD;
					case 'e': return Language.ITE;
					case 'i': return Language.ITI;
					case 'k': return Language.ITK;
					case 'l': return Language.ITL;
					case 'm': return Language.ITM;
					case 'o': return Language.ITO;
					case 'r': return Language.ITR;
					case 's': return Language.ITS;
					case 't': return Language.ITT;
					case 'v': return Language.ITV;
					case 'w': return Language.ITW;
					case 'x': return Language.ITX;
					case 'y': return Language.ITY;
					case 'z': return Language.ITZ;
				}
				offset--;
			}
			return Language.IT;
		}

		private static Language? tryParseFromLanguage_iu(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'm': return Language.IUM;
				}
				offset--;
			}
			return Language.IU;
		}

		private static Language? tryParseFromLanguage_iw(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'k': return Language.IWK;
					case 'm': return Language.IWM;
					case 'o': return Language.IWO;
					case 's': return Language.IWS;
				}
				offset--;
			}
			return Language.HE;
		}

		private static Language? tryParseFromLanguage_ib(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.IBA;
					case 'b': return Language.IBB;
					case 'd': return Language.IBD;
					case 'e': return Language.IBE;
					case 'g': return Language.IBG;
					case 'i': return Language.OPA;
					case 'l': return Language.IBL;
					case 'm': return Language.IBM;
					case 'n': return Language.IBN;
					case 'r': return Language.IBR;
					case 'u': return Language.IBU;
					case 'y': return Language.IBY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ic(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.ICA;
					case 'h': return Language.ICH;
					case 'l': return Language.ICL;
					case 'r': return Language.ICR;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_if(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.IFA;
					case 'b': return Language.IFB;
					case 'e': return Language.IFE;
					case 'f': return Language.IFF;
					case 'k': return Language.IFK;
					case 'm': return Language.IFM;
					case 'u': return Language.IFU;
					case 'y': return Language.IFY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ih(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.IHB;
					case 'i': return Language.IHI;
					case 'p': return Language.IHP;
					case 'w': return Language.IHW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ij(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'c': return Language.IJC;
					case 'e': return Language.IJE;
					case 'j': return Language.IJJ;
					case 'n': return Language.IJN;
					case 'o': return Language.IJO;
					case 's': return Language.IJS;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_il(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.ILA;
					case 'b': return Language.ILB;
					case 'g': return Language.ILG;
					case 'i': return Language.ILI;
					case 'k': return Language.ILK;
					case 'l': return Language.ILL;
					case 'm': return Language.ILM;
					case 'o': return Language.ILO;
					case 'p': return Language.ILP;
					case 's': return Language.ILS;
					case 'u': return Language.ILU;
					case 'v': return Language.ILV;
					case 'w': return Language.GAL;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_im(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.IMA;
					case 'e': return Language.IME;
					case 'i': return Language.IMI;
					case 'l': return Language.IML;
					case 'n': return Language.IMN;
					case 'o': return Language.IMO;
					case 'r': return Language.IMR;
					case 's': return Language.IMS;
					case 'y': return Language.IMY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ip(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'i': return Language.IPI;
					case 'o': return Language.IPO;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_iq(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'u': return Language.IQU;
					case 'w': return Language.IQW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ir(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.IRA;
					case 'e': return Language.IRE;
					case 'h': return Language.IRH;
					case 'i': return Language.IRI;
					case 'k': return Language.IRK;
					case 'n': return Language.IRN;
					case 'o': return Language.IRO;
					case 'r': return Language.IRR;
					case 'u': return Language.IRU;
					case 'x': return Language.IRX;
					case 'y': return Language.IRY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_iv(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.IVB;
					case 'v': return Language.IVV;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ix(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'c': return Language.IXC;
					case 'l': return Language.IXL;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_iy(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.IYA;
					case 'o': return Language.IYO;
					case 'x': return Language.IYX;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_iz(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'h': return Language.IZH;
					case 'i': return Language.IZI;
					case 'r': return Language.IZR;
					case 'z': return Language.IZZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_j(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return tryParseFromLanguage_ja(text, ref offset);
					case 'i': return tryParseFromLanguage_ji(text, ref offset);
					case 'v': return tryParseFromLanguage_jv(text, ref offset);
					case 'w': return tryParseFromLanguage_jw(text, ref offset);
					case 'b': return tryParseFromLanguage_jb(text, ref offset);
					case 'c': return tryParseFromLanguage_jc(text, ref offset);
					case 'd': return tryParseFromLanguage_jd(text, ref offset);
					case 'e': return tryParseFromLanguage_je(text, ref offset);
					case 'g': return tryParseFromLanguage_jg(text, ref offset);
					case 'h': return tryParseFromLanguage_jh(text, ref offset);
					case 'j': return tryParseFromLanguage_jj(text, ref offset);
					case 'k': return tryParseFromLanguage_jk(text, ref offset);
					case 'l': return tryParseFromLanguage_jl(text, ref offset);
					case 'm': return tryParseFromLanguage_jm(text, ref offset);
					case 'n': return tryParseFromLanguage_jn(text, ref offset);
					case 'o': return tryParseFromLanguage_jo(text, ref offset);
					case 'p': return tryParseFromLanguage_jp(text, ref offset);
					case 'q': return tryParseFromLanguage_jq(text, ref offset);
					case 'r': return tryParseFromLanguage_jr(text, ref offset);
					case 's': return tryParseFromLanguage_js(text, ref offset);
					case 'u': return tryParseFromLanguage_ju(text, ref offset);
					case 'y': return tryParseFromLanguage_jy(text, ref offset);
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ja(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.JAA;
					case 'b': return Language.JAB;
					case 'c': return Language.JAC;
					case 'd': return Language.JAD;
					case 'e': return Language.JAE;
					case 'f': return Language.JAF;
					case 'h': return Language.JAH;
					case 'j': return Language.JAJ;
					case 'k': return Language.JAK;
					case 'l': return Language.JAL;
					case 'm': return Language.JAM;
					case 'n': return Language.JAN;
					case 'o': return Language.JAO;
					case 'q': return Language.JAQ;
					case 'r': return Language.JAR;
					case 's': return Language.JAS;
					case 't': return Language.JAT;
					case 'u': return Language.JAU;
					case 'x': return Language.JAX;
					case 'y': return Language.JAY;
					case 'z': return Language.JAZ;
				}
				offset--;
			}
			return Language.JA;
		}

		private static Language? tryParseFromLanguage_ji(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.JIA;
					case 'b': return Language.JIB;
					case 'c': return Language.JIC;
					case 'd': return Language.JID;
					case 'e': return Language.JIE;
					case 'g': return Language.JIG;
					case 'h': return Language.JIH;
					case 'i': return Language.JII;
					case 'l': return Language.JIL;
					case 'm': return Language.JIM;
					case 'o': return Language.JIO;
					case 'q': return Language.JIQ;
					case 't': return Language.JIT;
					case 'u': return Language.JIU;
					case 'v': return Language.JIV;
					case 'y': return Language.JIY;
				}
				offset--;
			}
			return Language.YI;
		}

		private static Language? tryParseFromLanguage_jv(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'd': return Language.JVD;
					case 'n': return Language.JVN;
				}
				offset--;
			}
			return Language.JV;
		}

		private static Language? tryParseFromLanguage_jw(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'i': return Language.JWI;
				}
				offset--;
			}
			return Language.JV;
		}

		private static Language? tryParseFromLanguage_jb(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'e': return Language.JBE;
					case 'i': return Language.JBI;
					case 'j': return Language.JBJ;
					case 'k': return Language.JBK;
					case 'n': return Language.JBN;
					case 'o': return Language.JBO;
					case 'r': return Language.JBR;
					case 't': return Language.JBT;
					case 'u': return Language.JBU;
					case 'w': return Language.JBW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_jc(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 's': return Language.JCS;
					case 't': return Language.JCT;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_jd(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.JDA;
					case 'g': return Language.JDG;
					case 't': return Language.JDT;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_je(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.JEB;
					case 'e': return Language.JEE;
					case 'g': return Language.JEG;
					case 'h': return Language.JEH;
					case 'i': return Language.JEI;
					case 'k': return Language.JEK;
					case 'l': return Language.JEL;
					case 'n': return Language.JEN;
					case 'r': return Language.JER;
					case 't': return Language.JET;
					case 'u': return Language.JEU;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_jg(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.JGB;
					case 'e': return Language.JGE;
					case 'k': return Language.JGK;
					case 'o': return Language.JGO;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_jh(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'i': return Language.JHI;
					case 's': return Language.JHS;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_jj(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'e': return Language.JJE;
					case 'r': return Language.JJR;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_jk(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.JKA;
					case 'm': return Language.JKM;
					case 'o': return Language.JKO;
					case 'p': return Language.JKP;
					case 'r': return Language.JKR;
					case 'u': return Language.JKU;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_jl(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'e': return Language.JLE;
					case 's': return Language.JLS;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_jm(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.JMA;
					case 'b': return Language.JMB;
					case 'c': return Language.JMC;
					case 'd': return Language.JMD;
					case 'i': return Language.JMI;
					case 'l': return Language.JML;
					case 'n': return Language.JMN;
					case 'r': return Language.JMR;
					case 's': return Language.JMS;
					case 'w': return Language.JMW;
					case 'x': return Language.JMX;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_jn(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.JNA;
					case 'd': return Language.JND;
					case 'g': return Language.JNG;
					case 'i': return Language.JNI;
					case 'j': return Language.JNJ;
					case 'l': return Language.JNL;
					case 's': return Language.JNS;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_jo(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.JOB;
					case 'd': return Language.JOD;
					case 'g': return Language.JOG;
					case 'r': return Language.JOR;
					case 's': return Language.JOS;
					case 'w': return Language.JOW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_jp(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.JPA;
					case 'r': return Language.JPR;
					case 'x': return Language.JPX;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_jq(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'r': return Language.JQR;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_jr(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.JRA;
					case 'b': return Language.JRB;
					case 'r': return Language.JRR;
					case 't': return Language.JRT;
					case 'u': return Language.JRU;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_js(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'l': return Language.JSL;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ju(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.JUA;
					case 'b': return Language.JUB;
					case 'c': return Language.JUC;
					case 'd': return Language.JUD;
					case 'h': return Language.JUH;
					case 'i': return Language.JUI;
					case 'k': return Language.JUK;
					case 'l': return Language.JUL;
					case 'm': return Language.JUM;
					case 'n': return Language.JUN;
					case 'o': return Language.JUO;
					case 'p': return Language.JUP;
					case 'r': return Language.JUR;
					case 's': return Language.JUS;
					case 't': return Language.JUT;
					case 'u': return Language.JUU;
					case 'w': return Language.JUW;
					case 'y': return Language.JUY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_jy(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.JYA;
					case 'e': return Language.JYE;
					case 'y': return Language.JYY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_k(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return tryParseFromLanguage_ka(text, ref offset);
					case 'g': return tryParseFromLanguage_kg(text, ref offset);
					case 'i': return tryParseFromLanguage_ki(text, ref offset);
					case 'j': return tryParseFromLanguage_kj(text, ref offset);
					case 'k': return tryParseFromLanguage_kk(text, ref offset);
					case 'l': return tryParseFromLanguage_kl(text, ref offset);
					case 'm': return tryParseFromLanguage_km(text, ref offset);
					case 'n': return tryParseFromLanguage_kn(text, ref offset);
					case 'o': return tryParseFromLanguage_ko(text, ref offset);
					case 'r': return tryParseFromLanguage_kr(text, ref offset);
					case 's': return tryParseFromLanguage_ks(text, ref offset);
					case 'u': return tryParseFromLanguage_ku(text, ref offset);
					case 'v': return tryParseFromLanguage_kv(text, ref offset);
					case 'w': return tryParseFromLanguage_kw(text, ref offset);
					case 'y': return tryParseFromLanguage_ky(text, ref offset);
					case 'b': return tryParseFromLanguage_kb(text, ref offset);
					case 'c': return tryParseFromLanguage_kc(text, ref offset);
					case 'd': return tryParseFromLanguage_kd(text, ref offset);
					case 'e': return tryParseFromLanguage_ke(text, ref offset);
					case 'f': return tryParseFromLanguage_kf(text, ref offset);
					case 'h': return tryParseFromLanguage_kh(text, ref offset);
					case 'p': return tryParseFromLanguage_kp(text, ref offset);
					case 'q': return tryParseFromLanguage_kq(text, ref offset);
					case 't': return tryParseFromLanguage_kt(text, ref offset);
					case 'x': return tryParseFromLanguage_kx(text, ref offset);
					case 'z': return tryParseFromLanguage_kz(text, ref offset);
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ka(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.KAA;
					case 'b': return Language.KAB;
					case 'c': return Language.KAC;
					case 'd': return Language.KAD;
					case 'e': return Language.KAE;
					case 'f': return Language.KAF;
					case 'g': return Language.KAG;
					case 'h': return Language.KAH;
					case 'i': return Language.KAI;
					case 'j': return Language.KAJ;
					case 'k': return Language.KAK;
					case 'm': return Language.KAM;
					case 'o': return Language.KAO;
					case 'p': return Language.KAP;
					case 'q': return Language.KAQ;
					case 'r': return Language.KAR;
					case 'v': return Language.KAV;
					case 'w': return Language.KAW;
					case 'x': return Language.KAX;
					case 'y': return Language.KAY;
				}
				offset--;
			}
			return Language.KA;
		}

		private static Language? tryParseFromLanguage_kg(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.KGA;
					case 'b': return Language.KGB;
					case 'c': return Language.TDF;
					case 'd': return Language.KGD;
					case 'e': return Language.KGE;
					case 'f': return Language.KGF;
					case 'g': return Language.KGG;
					case 'h': return Language.KML;
					case 'i': return Language.KGI;
					case 'j': return Language.KGJ;
					case 'k': return Language.KGK;
					case 'l': return Language.KGL;
					case 'm': return Language.KGM;
					case 'n': return Language.KGN;
					case 'o': return Language.KGO;
					case 'p': return Language.KGP;
					case 'q': return Language.KGQ;
					case 'r': return Language.KGR;
					case 's': return Language.KGS;
					case 't': return Language.KGT;
					case 'u': return Language.KGU;
					case 'v': return Language.KGV;
					case 'w': return Language.KGW;
					case 'x': return Language.KGX;
					case 'y': return Language.KGY;
				}
				offset--;
			}
			return Language.KG;
		}

		private static Language? tryParseFromLanguage_ki(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.KIA;
					case 'b': return Language.KIB;
					case 'c': return Language.KIC;
					case 'd': return Language.KID;
					case 'e': return Language.KIE;
					case 'f': return Language.KIF;
					case 'g': return Language.KIG;
					case 'h': return Language.KIH;
					case 'i': return Language.KII;
					case 'j': return Language.KIJ;
					case 'l': return Language.KIL;
					case 'm': return Language.KIM;
					case 'o': return Language.KIO;
					case 'p': return Language.KIP;
					case 'q': return Language.KIQ;
					case 's': return Language.KIS;
					case 't': return Language.KIT;
					case 'u': return Language.KIU;
					case 'v': return Language.KIV;
					case 'w': return Language.KIW;
					case 'x': return Language.KIX;
					case 'y': return Language.KIY;
					case 'z': return Language.KIZ;
				}
				offset--;
			}
			return Language.KI;
		}

		private static Language? tryParseFromLanguage_kj(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.KJA;
					case 'b': return Language.KJB;
					case 'c': return Language.KJC;
					case 'd': return Language.KJD;
					case 'e': return Language.KJE;
					case 'f': return Language.KJF;
					case 'g': return Language.KJG;
					case 'h': return Language.KJH;
					case 'i': return Language.KJI;
					case 'j': return Language.KJJ;
					case 'k': return Language.KJK;
					case 'l': return Language.KJL;
					case 'm': return Language.KJM;
					case 'n': return Language.KJN;
					case 'o': return Language.KJO;
					case 'p': return Language.KJP;
					case 'q': return Language.KJQ;
					case 'r': return Language.KJR;
					case 's': return Language.KJS;
					case 't': return Language.KJT;
					case 'u': return Language.KJU;
					case 'v': return Language.KJV;
					case 'x': return Language.KJX;
					case 'y': return Language.KJY;
					case 'z': return Language.KJZ;
				}
				offset--;
			}
			return Language.KJ;
		}

		private static Language? tryParseFromLanguage_kk(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.KKA;
					case 'b': return Language.KKB;
					case 'c': return Language.KKC;
					case 'd': return Language.KKD;
					case 'e': return Language.KKE;
					case 'f': return Language.KKF;
					case 'g': return Language.KKG;
					case 'h': return Language.KKH;
					case 'i': return Language.KKI;
					case 'j': return Language.KKJ;
					case 'k': return Language.KKK;
					case 'l': return Language.KKL;
					case 'm': return Language.KKM;
					case 'n': return Language.KKN;
					case 'o': return Language.KKO;
					case 'p': return Language.KKP;
					case 'q': return Language.KKQ;
					case 'r': return Language.KKR;
					case 's': return Language.KKS;
					case 't': return Language.KKT;
					case 'u': return Language.KKU;
					case 'v': return Language.KKV;
					case 'w': return Language.KKW;
					case 'x': return Language.KKX;
					case 'y': return Language.KKY;
					case 'z': return Language.KKZ;
				}
				offset--;
			}
			return Language.KK;
		}

		private static Language? tryParseFromLanguage_kl(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.KLA;
					case 'b': return Language.KLB;
					case 'c': return Language.KLC;
					case 'd': return Language.KLD;
					case 'e': return Language.KLE;
					case 'f': return Language.KLF;
					case 'g': return Language.KLG;
					case 'h': return Language.KLH;
					case 'i': return Language.KLI;
					case 'j': return Language.KLJ;
					case 'k': return Language.KLK;
					case 'l': return Language.KLL;
					case 'm': return Language.KLM;
					case 'n': return Language.KLN;
					case 'o': return Language.KLO;
					case 'p': return Language.KLP;
					case 'q': return Language.KLQ;
					case 'r': return Language.KLR;
					case 's': return Language.KLS;
					case 't': return Language.KLT;
					case 'u': return Language.KLU;
					case 'v': return Language.KLV;
					case 'w': return Language.KLW;
					case 'x': return Language.KLX;
					case 'y': return Language.KLY;
					case 'z': return Language.KLZ;
				}
				offset--;
			}
			return Language.KL;
		}

		private static Language? tryParseFromLanguage_km(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.KMA;
					case 'b': return Language.KMB;
					case 'c': return Language.KMC;
					case 'd': return Language.KMD;
					case 'e': return Language.KME;
					case 'f': return Language.KMF;
					case 'g': return Language.KMG;
					case 'h': return Language.KMH;
					case 'i': return Language.KMI;
					case 'j': return Language.KMJ;
					case 'k': return Language.KMK;
					case 'l': return Language.KML;
					case 'm': return Language.KMM;
					case 'n': return Language.KMN;
					case 'o': return Language.KMO;
					case 'p': return Language.KMP;
					case 'q': return Language.KMQ;
					case 'r': return Language.KMR;
					case 's': return Language.KMS;
					case 't': return Language.KMT;
					case 'u': return Language.KMU;
					case 'v': return Language.KMV;
					case 'w': return Language.KMW;
					case 'x': return Language.KMX;
					case 'y': return Language.KMY;
					case 'z': return Language.KMZ;
				}
				offset--;
			}
			return Language.KM;
		}

		private static Language? tryParseFromLanguage_kn(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.KNA;
					case 'b': return Language.KNB;
					case 'c': return Language.KNC;
					case 'd': return Language.KND;
					case 'e': return Language.KNE;
					case 'f': return Language.KNF;
					case 'g': return Language.KNG;
					case 'i': return Language.KNI;
					case 'j': return Language.KNJ;
					case 'k': return Language.KNK;
					case 'l': return Language.KNL;
					case 'm': return Language.KNM;
					case 'n': return Language.KNN;
					case 'o': return Language.KNO;
					case 'p': return Language.KNP;
					case 'q': return Language.KNQ;
					case 'r': return Language.KNR;
					case 's': return Language.KNS;
					case 't': return Language.KNT;
					case 'u': return Language.KNU;
					case 'v': return Language.KNV;
					case 'w': return Language.KNW;
					case 'x': return Language.KNX;
					case 'y': return Language.KNY;
					case 'z': return Language.KNZ;
				}
				offset--;
			}
			return Language.KN;
		}

		private static Language? tryParseFromLanguage_ko(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.KOA;
					case 'c': return Language.KOC;
					case 'd': return Language.KOD;
					case 'e': return Language.KOE;
					case 'f': return Language.KOF;
					case 'g': return Language.KOG;
					case 'h': return Language.KOH;
					case 'i': return Language.KOI;
					case 'j': return Language.KWV;
					case 'k': return Language.KOK;
					case 'l': return Language.KOL;
					case 'o': return Language.KOO;
					case 'p': return Language.KOP;
					case 'q': return Language.KOQ;
					case 's': return Language.KOS;
					case 't': return Language.KOT;
					case 'u': return Language.KOU;
					case 'v': return Language.KOV;
					case 'w': return Language.KOW;
					case 'x': return Language.KOX;
					case 'y': return Language.KOY;
					case 'z': return Language.KOZ;
				}
				offset--;
			}
			return Language.KO;
		}

		private static Language? tryParseFromLanguage_kr(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.KRA;
					case 'b': return Language.KRB;
					case 'c': return Language.KRC;
					case 'd': return Language.KRD;
					case 'e': return Language.KRE;
					case 'f': return Language.KRF;
					case 'h': return Language.KRH;
					case 'i': return Language.KRI;
					case 'j': return Language.KRJ;
					case 'k': return Language.KRK;
					case 'l': return Language.KRL;
					case 'm': return Language.KRM;
					case 'n': return Language.KRN;
					case 'o': return Language.KRO;
					case 'p': return Language.KRP;
					case 'r': return Language.KRR;
					case 's': return Language.KRS;
					case 't': return Language.KRT;
					case 'u': return Language.KRU;
					case 'v': return Language.KRV;
					case 'w': return Language.KRW;
					case 'x': return Language.KRX;
					case 'y': return Language.KRY;
					case 'z': return Language.KRZ;
				}
				offset--;
			}
			return Language.KR;
		}

		private static Language? tryParseFromLanguage_ks(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.KSA;
					case 'b': return Language.KSB;
					case 'c': return Language.KSC;
					case 'd': return Language.KSD;
					case 'e': return Language.KSE;
					case 'f': return Language.KSF;
					case 'g': return Language.KSG;
					case 'h': return Language.KSH;
					case 'i': return Language.KSI;
					case 'j': return Language.KSJ;
					case 'k': return Language.KSK;
					case 'l': return Language.KSL;
					case 'm': return Language.KSM;
					case 'n': return Language.KSN;
					case 'o': return Language.KSO;
					case 'p': return Language.KSP;
					case 'q': return Language.KSQ;
					case 'r': return Language.KSR;
					case 's': return Language.KSS;
					case 't': return Language.KST;
					case 'u': return Language.KSU;
					case 'v': return Language.KSV;
					case 'w': return Language.KSW;
					case 'x': return Language.KSX;
					case 'y': return Language.KSY;
					case 'z': return Language.KSZ;
				}
				offset--;
			}
			return Language.KS;
		}

		private static Language? tryParseFromLanguage_ku(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.KUB;
					case 'c': return Language.KUC;
					case 'd': return Language.KUD;
					case 'e': return Language.KUE;
					case 'f': return Language.KUF;
					case 'g': return Language.KUG;
					case 'h': return Language.KUH;
					case 'i': return Language.KUI;
					case 'j': return Language.KUJ;
					case 'k': return Language.KUK;
					case 'l': return Language.KUL;
					case 'm': return Language.KUM;
					case 'n': return Language.KUN;
					case 'o': return Language.KUO;
					case 'p': return Language.KUP;
					case 'q': return Language.KUQ;
					case 's': return Language.KUS;
					case 't': return Language.KUT;
					case 'u': return Language.KUU;
					case 'v': return Language.KUV;
					case 'w': return Language.KUW;
					case 'x': return Language.KUX;
					case 'y': return Language.KUY;
					case 'z': return Language.KUZ;
				}
				offset--;
			}
			return Language.KU;
		}

		private static Language? tryParseFromLanguage_kv(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.KVA;
					case 'b': return Language.KVB;
					case 'c': return Language.KVC;
					case 'd': return Language.KVD;
					case 'e': return Language.KVE;
					case 'f': return Language.KVF;
					case 'g': return Language.KVG;
					case 'h': return Language.KVH;
					case 'i': return Language.KVI;
					case 'j': return Language.KVJ;
					case 'k': return Language.KVK;
					case 'l': return Language.KVL;
					case 'm': return Language.KVM;
					case 'n': return Language.KVN;
					case 'o': return Language.KVO;
					case 'p': return Language.KVP;
					case 'q': return Language.KVQ;
					case 'r': return Language.KVR;
					case 's': return Language.GDJ;
					case 't': return Language.KVT;
					case 'u': return Language.KVU;
					case 'v': return Language.KVV;
					case 'w': return Language.KVW;
					case 'x': return Language.KVX;
					case 'y': return Language.KVY;
					case 'z': return Language.KVZ;
				}
				offset--;
			}
			return Language.KV;
		}

		private static Language? tryParseFromLanguage_kw(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.KWA;
					case 'b': return Language.KWB;
					case 'c': return Language.KWC;
					case 'd': return Language.KWD;
					case 'e': return Language.KWE;
					case 'f': return Language.KWF;
					case 'g': return Language.KWG;
					case 'h': return Language.KWH;
					case 'i': return Language.KWI;
					case 'j': return Language.KWJ;
					case 'k': return Language.KWK;
					case 'l': return Language.KWL;
					case 'm': return Language.KWM;
					case 'n': return Language.KWN;
					case 'o': return Language.KWO;
					case 'p': return Language.KWP;
					case 'q': return Language.YAM;
					case 'r': return Language.KWR;
					case 's': return Language.KWS;
					case 't': return Language.KWT;
					case 'u': return Language.KWU;
					case 'v': return Language.KWV;
					case 'w': return Language.KWW;
					case 'x': return Language.KWX;
					case 'y': return Language.KWY;
					case 'z': return Language.KWZ;
				}
				offset--;
			}
			return Language.KW;
		}

		private static Language? tryParseFromLanguage_ky(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.KYA;
					case 'b': return Language.KYB;
					case 'c': return Language.KYC;
					case 'd': return Language.KYD;
					case 'e': return Language.KYE;
					case 'f': return Language.KYF;
					case 'g': return Language.KYG;
					case 'h': return Language.KYH;
					case 'i': return Language.KYI;
					case 'j': return Language.KYJ;
					case 'k': return Language.KYK;
					case 'l': return Language.KYL;
					case 'm': return Language.KYM;
					case 'n': return Language.KYN;
					case 'o': return Language.KYO;
					case 'p': return Language.KYP;
					case 'q': return Language.KYQ;
					case 'r': return Language.KYR;
					case 's': return Language.KYS;
					case 't': return Language.KYT;
					case 'u': return Language.KYU;
					case 'v': return Language.KYV;
					case 'w': return Language.KYW;
					case 'x': return Language.KYX;
					case 'y': return Language.KYY;
					case 'z': return Language.KYZ;
				}
				offset--;
			}
			return Language.KY;
		}

		private static Language? tryParseFromLanguage_kb(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.KBA;
					case 'b': return Language.KBB;
					case 'c': return Language.KBC;
					case 'd': return Language.KBD;
					case 'e': return Language.KBE;
					case 'f': return Language.KBF;
					case 'g': return Language.KBG;
					case 'h': return Language.KBH;
					case 'i': return Language.KBI;
					case 'j': return Language.KBJ;
					case 'k': return Language.KBK;
					case 'l': return Language.KBL;
					case 'm': return Language.KBM;
					case 'n': return Language.KBN;
					case 'o': return Language.KBO;
					case 'p': return Language.KBP;
					case 'q': return Language.KBQ;
					case 'r': return Language.KBR;
					case 's': return Language.KBS;
					case 't': return Language.KBT;
					case 'u': return Language.KBU;
					case 'v': return Language.KBV;
					case 'w': return Language.KBW;
					case 'x': return Language.KBX;
					case 'y': return Language.KBY;
					case 'z': return Language.KBZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_kc(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.KCA;
					case 'b': return Language.KCB;
					case 'c': return Language.KCC;
					case 'd': return Language.KCD;
					case 'e': return Language.KCE;
					case 'f': return Language.KCF;
					case 'g': return Language.KCG;
					case 'h': return Language.KCH;
					case 'i': return Language.KCI;
					case 'j': return Language.KCJ;
					case 'k': return Language.KCK;
					case 'l': return Language.KCL;
					case 'm': return Language.KCM;
					case 'n': return Language.KCN;
					case 'o': return Language.KCO;
					case 'p': return Language.KCP;
					case 'q': return Language.KCQ;
					case 'r': return Language.KCR;
					case 's': return Language.KCS;
					case 't': return Language.KCT;
					case 'u': return Language.KCU;
					case 'v': return Language.KCV;
					case 'w': return Language.KCW;
					case 'x': return Language.KCX;
					case 'y': return Language.KCY;
					case 'z': return Language.KCZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_kd(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.KDA;
					case 'c': return Language.KDC;
					case 'd': return Language.KDD;
					case 'e': return Language.KDE;
					case 'f': return Language.KDF;
					case 'g': return Language.KDG;
					case 'h': return Language.KDH;
					case 'i': return Language.KDI;
					case 'j': return Language.KDJ;
					case 'k': return Language.KDK;
					case 'l': return Language.KDL;
					case 'm': return Language.KDM;
					case 'n': return Language.KDN;
					case 'o': return Language.KDO;
					case 'p': return Language.KDP;
					case 'q': return Language.KDQ;
					case 'r': return Language.KDR;
					case 't': return Language.KDT;
					case 'u': return Language.KDU;
					case 'v': return Language.KDV;
					case 'w': return Language.KDW;
					case 'x': return Language.KDX;
					case 'y': return Language.KDY;
					case 'z': return Language.KDZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ke(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.KEA;
					case 'b': return Language.KEB;
					case 'c': return Language.KEC;
					case 'd': return Language.KED;
					case 'e': return Language.KEE;
					case 'f': return Language.KEF;
					case 'g': return Language.KEG;
					case 'h': return Language.KEH;
					case 'i': return Language.KEI;
					case 'j': return Language.KEJ;
					case 'k': return Language.KEK;
					case 'l': return Language.KEL;
					case 'm': return Language.KEM;
					case 'n': return Language.KEN;
					case 'o': return Language.KEO;
					case 'p': return Language.KEP;
					case 'q': return Language.KEQ;
					case 'r': return Language.KER;
					case 's': return Language.KES;
					case 't': return Language.KET;
					case 'u': return Language.KEU;
					case 'v': return Language.KEV;
					case 'w': return Language.KEW;
					case 'x': return Language.KEX;
					case 'y': return Language.KEY;
					case 'z': return Language.KEZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_kf(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.KFA;
					case 'b': return Language.KFB;
					case 'c': return Language.KFC;
					case 'd': return Language.KFD;
					case 'e': return Language.KFE;
					case 'f': return Language.KFF;
					case 'g': return Language.KFG;
					case 'h': return Language.KFH;
					case 'i': return Language.KFI;
					case 'j': return Language.KFJ;
					case 'k': return Language.KFK;
					case 'l': return Language.KFL;
					case 'm': return Language.KFM;
					case 'n': return Language.KFN;
					case 'o': return Language.KFO;
					case 'p': return Language.KFP;
					case 'q': return Language.KFQ;
					case 'r': return Language.KFR;
					case 's': return Language.KFS;
					case 't': return Language.KFT;
					case 'u': return Language.KFU;
					case 'v': return Language.KFV;
					case 'w': return Language.KFW;
					case 'x': return Language.KFX;
					case 'y': return Language.KFY;
					case 'z': return Language.KFZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_kh(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.KHA;
					case 'b': return Language.KHB;
					case 'c': return Language.KHC;
					case 'd': return Language.KHD;
					case 'e': return Language.KHE;
					case 'f': return Language.KHF;
					case 'g': return Language.KHG;
					case 'h': return Language.KHH;
					case 'i': return Language.KHI;
					case 'j': return Language.KHJ;
					case 'k': return Language.KHK;
					case 'l': return Language.KHL;
					case 'n': return Language.KHN;
					case 'o': return Language.KHO;
					case 'p': return Language.KHP;
					case 'q': return Language.KHQ;
					case 'r': return Language.KHR;
					case 's': return Language.KHS;
					case 't': return Language.KHT;
					case 'u': return Language.KHU;
					case 'v': return Language.KHV;
					case 'w': return Language.KHW;
					case 'x': return Language.KHX;
					case 'y': return Language.KHY;
					case 'z': return Language.KHZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_kp(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.KPA;
					case 'b': return Language.KPB;
					case 'c': return Language.KPC;
					case 'd': return Language.KPD;
					case 'e': return Language.KPE;
					case 'f': return Language.KPF;
					case 'g': return Language.KPG;
					case 'h': return Language.KPH;
					case 'i': return Language.KPI;
					case 'j': return Language.KPJ;
					case 'k': return Language.KPK;
					case 'l': return Language.KPL;
					case 'm': return Language.KPM;
					case 'n': return Language.KPN;
					case 'o': return Language.KPO;
					case 'p': return Language.KPP;
					case 'q': return Language.KPQ;
					case 'r': return Language.KPR;
					case 's': return Language.KPS;
					case 't': return Language.KPT;
					case 'u': return Language.KPU;
					case 'v': return Language.KPV;
					case 'w': return Language.KPW;
					case 'x': return Language.KPX;
					case 'y': return Language.KPY;
					case 'z': return Language.KPZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_kq(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.KQA;
					case 'b': return Language.KQB;
					case 'c': return Language.KQC;
					case 'd': return Language.KQD;
					case 'e': return Language.KQE;
					case 'f': return Language.KQF;
					case 'g': return Language.KQG;
					case 'h': return Language.KQH;
					case 'i': return Language.KQI;
					case 'j': return Language.KQJ;
					case 'k': return Language.KQK;
					case 'l': return Language.KQL;
					case 'm': return Language.KQM;
					case 'n': return Language.KQN;
					case 'o': return Language.KQO;
					case 'p': return Language.KQP;
					case 'q': return Language.KQQ;
					case 'r': return Language.KQR;
					case 's': return Language.KQS;
					case 't': return Language.KQT;
					case 'u': return Language.KQU;
					case 'v': return Language.KQV;
					case 'w': return Language.KQW;
					case 'x': return Language.KQX;
					case 'y': return Language.KQY;
					case 'z': return Language.KQZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_kt(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.KTA;
					case 'b': return Language.KTB;
					case 'c': return Language.KTC;
					case 'd': return Language.KTD;
					case 'e': return Language.KTE;
					case 'f': return Language.KTF;
					case 'g': return Language.KTG;
					case 'h': return Language.KTH;
					case 'i': return Language.KTI;
					case 'j': return Language.KTJ;
					case 'k': return Language.KTK;
					case 'l': return Language.KTL;
					case 'm': return Language.KTM;
					case 'n': return Language.KTN;
					case 'o': return Language.KTO;
					case 'p': return Language.KTP;
					case 'q': return Language.KTQ;
					case 'r': return Language.DTP;
					case 's': return Language.KTS;
					case 't': return Language.KTT;
					case 'u': return Language.KTU;
					case 'v': return Language.KTV;
					case 'w': return Language.KTW;
					case 'x': return Language.KTX;
					case 'y': return Language.KTY;
					case 'z': return Language.KTZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_kx(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.KXA;
					case 'b': return Language.KXB;
					case 'c': return Language.KXC;
					case 'd': return Language.KXD;
					case 'e': return Language.TVD;
					case 'f': return Language.KXF;
					case 'h': return Language.KXH;
					case 'i': return Language.KXI;
					case 'j': return Language.KXJ;
					case 'k': return Language.KXK;
					case 'l': return Language.KXL;
					case 'm': return Language.KXM;
					case 'n': return Language.KXN;
					case 'o': return Language.KXO;
					case 'p': return Language.KXP;
					case 'q': return Language.KXQ;
					case 'r': return Language.KXR;
					case 's': return Language.KXS;
					case 't': return Language.KXT;
					case 'u': return Language.KXU;
					case 'v': return Language.KXV;
					case 'w': return Language.KXW;
					case 'x': return Language.KXX;
					case 'y': return Language.KXY;
					case 'z': return Language.KXZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_kz(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.KZA;
					case 'b': return Language.KZB;
					case 'c': return Language.KZC;
					case 'd': return Language.KZD;
					case 'e': return Language.KZE;
					case 'f': return Language.KZF;
					case 'g': return Language.KZG;
					case 'h': return Language.KZH;
					case 'i': return Language.KZI;
					case 'j': return Language.DTP;
					case 'k': return Language.KZK;
					case 'l': return Language.KZL;
					case 'm': return Language.KZM;
					case 'n': return Language.KZN;
					case 'o': return Language.KZO;
					case 'p': return Language.KZP;
					case 'q': return Language.KZQ;
					case 'r': return Language.KZR;
					case 's': return Language.KZS;
					case 't': return Language.DTP;
					case 'u': return Language.KZU;
					case 'v': return Language.KZV;
					case 'w': return Language.KZW;
					case 'x': return Language.KZX;
					case 'y': return Language.KZY;
					case 'z': return Language.KZZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_l(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return tryParseFromLanguage_la(text, ref offset);
					case 'b': return tryParseFromLanguage_lb(text, ref offset);
					case 'g': return tryParseFromLanguage_lg(text, ref offset);
					case 'i': return tryParseFromLanguage_li(text, ref offset);
					case 'n': return tryParseFromLanguage_ln(text, ref offset);
					case 'o': return tryParseFromLanguage_lo(text, ref offset);
					case 't': return tryParseFromLanguage_lt(text, ref offset);
					case 'u': return tryParseFromLanguage_lu(text, ref offset);
					case 'v': return tryParseFromLanguage_lv(text, ref offset);
					case 'c': return tryParseFromLanguage_lc(text, ref offset);
					case 'd': return tryParseFromLanguage_ld(text, ref offset);
					case 'e': return tryParseFromLanguage_le(text, ref offset);
					case 'f': return tryParseFromLanguage_lf(text, ref offset);
					case 'h': return tryParseFromLanguage_lh(text, ref offset);
					case 'j': return tryParseFromLanguage_lj(text, ref offset);
					case 'k': return tryParseFromLanguage_lk(text, ref offset);
					case 'l': return tryParseFromLanguage_ll(text, ref offset);
					case 'm': return tryParseFromLanguage_lm(text, ref offset);
					case 'p': return tryParseFromLanguage_lp(text, ref offset);
					case 'r': return tryParseFromLanguage_lr(text, ref offset);
					case 's': return tryParseFromLanguage_ls(text, ref offset);
					case 'w': return tryParseFromLanguage_lw(text, ref offset);
					case 'y': return tryParseFromLanguage_ly(text, ref offset);
					case 'z': return tryParseFromLanguage_lz(text, ref offset);
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_la(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.LAA;
					case 'b': return Language.LAB;
					case 'c': return Language.LAC;
					case 'd': return Language.LAD;
					case 'e': return Language.LAE;
					case 'f': return Language.LAF;
					case 'g': return Language.LAG;
					case 'h': return Language.LAH;
					case 'i': return Language.LAI;
					case 'j': return Language.LAJ;
					case 'k': return Language.LAK;
					case 'l': return Language.LAL;
					case 'm': return Language.LAM;
					case 'n': return Language.LAN;
					case 'p': return Language.LAP;
					case 'q': return Language.LAQ;
					case 'r': return Language.LAR;
					case 's': return Language.LAS;
					case 'u': return Language.LAU;
					case 'w': return Language.LAW;
					case 'x': return Language.LAX;
					case 'y': return Language.LAY;
					case 'z': return Language.LAZ;
				}
				offset--;
			}
			return Language.LA;
		}

		private static Language? tryParseFromLanguage_lb(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.LBA;
					case 'b': return Language.LBB;
					case 'c': return Language.LBC;
					case 'e': return Language.LBE;
					case 'f': return Language.LBF;
					case 'g': return Language.LBG;
					case 'i': return Language.LBI;
					case 'j': return Language.LBJ;
					case 'k': return Language.LBK;
					case 'l': return Language.LBL;
					case 'm': return Language.LBM;
					case 'n': return Language.LBN;
					case 'o': return Language.LBO;
					case 'q': return Language.LBQ;
					case 'r': return Language.LBR;
					case 's': return Language.LBS;
					case 't': return Language.LBT;
					case 'u': return Language.LBU;
					case 'v': return Language.LBV;
					case 'w': return Language.LBW;
					case 'x': return Language.LBX;
					case 'y': return Language.LBY;
					case 'z': return Language.LBZ;
				}
				offset--;
			}
			return Language.LB;
		}

		private static Language? tryParseFromLanguage_lg(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.LGA;
					case 'b': return Language.LGB;
					case 'g': return Language.LGG;
					case 'h': return Language.LGH;
					case 'i': return Language.LGI;
					case 'k': return Language.LGK;
					case 'l': return Language.LGL;
					case 'm': return Language.LGM;
					case 'n': return Language.LGN;
					case 'q': return Language.LGQ;
					case 'r': return Language.LGR;
					case 't': return Language.LGT;
					case 'u': return Language.LGU;
					case 'z': return Language.LGZ;
				}
				offset--;
			}
			return Language.LG;
		}

		private static Language? tryParseFromLanguage_li(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.LIA;
					case 'b': return Language.LIB;
					case 'c': return Language.LIC;
					case 'd': return Language.LID;
					case 'e': return Language.LIE;
					case 'f': return Language.LIF;
					case 'g': return Language.LIG;
					case 'h': return Language.LIH;
					case 'i': return Language.RAQ;
					case 'j': return Language.LIJ;
					case 'k': return Language.LIK;
					case 'l': return Language.LIL;
					case 'o': return Language.LIO;
					case 'p': return Language.LIP;
					case 'q': return Language.LIQ;
					case 'r': return Language.LIR;
					case 's': return Language.LIS;
					case 'u': return Language.LIU;
					case 'v': return Language.LIV;
					case 'w': return Language.LIW;
					case 'x': return Language.LIX;
					case 'y': return Language.LIY;
					case 'z': return Language.LIZ;
				}
				offset--;
			}
			return Language.LI;
		}

		private static Language? tryParseFromLanguage_ln(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.LNA;
					case 'b': return Language.LNB;
					case 'd': return Language.LND;
					case 'g': return Language.LNG;
					case 'h': return Language.LNH;
					case 'i': return Language.LNI;
					case 'j': return Language.LNJ;
					case 'l': return Language.LNL;
					case 'm': return Language.LNM;
					case 'n': return Language.LNN;
					case 'o': return Language.LNO;
					case 's': return Language.LNS;
					case 'u': return Language.LNU;
					case 'w': return Language.LNW;
					case 'z': return Language.LNZ;
				}
				offset--;
			}
			return Language.LN;
		}

		private static Language? tryParseFromLanguage_lo(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.LOA;
					case 'b': return Language.LOB;
					case 'c': return Language.LOC;
					case 'e': return Language.LOE;
					case 'f': return Language.LOF;
					case 'g': return Language.LOG;
					case 'h': return Language.LOH;
					case 'i': return Language.LOI;
					case 'j': return Language.LOJ;
					case 'k': return Language.LOK;
					case 'l': return Language.LOL;
					case 'm': return Language.LOM;
					case 'n': return Language.LON;
					case 'o': return Language.LOO;
					case 'p': return Language.LOP;
					case 'q': return Language.LOQ;
					case 'r': return Language.LOR;
					case 's': return Language.LOS;
					case 't': return Language.LOT;
					case 'u': return Language.LOU;
					case 'v': return Language.LOV;
					case 'w': return Language.LOW;
					case 'x': return Language.LOX;
					case 'y': return Language.LOY;
					case 'z': return Language.LOZ;
				}
				offset--;
			}
			return Language.LO;
		}

		private static Language? tryParseFromLanguage_lt(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'c': return Language.LTC;
					case 'g': return Language.LTG;
					case 'i': return Language.LTI;
					case 'n': return Language.LTN;
					case 'o': return Language.LTO;
					case 's': return Language.LTS;
					case 'u': return Language.LTU;
				}
				offset--;
			}
			return Language.LT;
		}

		private static Language? tryParseFromLanguage_lu(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.LUA;
					case 'c': return Language.LUC;
					case 'd': return Language.LUD;
					case 'e': return Language.LUE;
					case 'f': return Language.LUF;
					case 'i': return Language.LUI;
					case 'j': return Language.LUJ;
					case 'k': return Language.LUK;
					case 'l': return Language.LUL;
					case 'm': return Language.LUM;
					case 'n': return Language.LUN;
					case 'o': return Language.LUO;
					case 'p': return Language.LUP;
					case 'q': return Language.LUQ;
					case 'r': return Language.LUR;
					case 's': return Language.LUS;
					case 't': return Language.LUT;
					case 'u': return Language.LUU;
					case 'v': return Language.LUV;
					case 'w': return Language.LUW;
					case 'y': return Language.LUY;
					case 'z': return Language.LUZ;
				}
				offset--;
			}
			return Language.LU;
		}

		private static Language? tryParseFromLanguage_lv(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.LVA;
					case 'k': return Language.LVK;
					case 's': return Language.LVS;
					case 'u': return Language.LVU;
				}
				offset--;
			}
			return Language.LV;
		}

		private static Language? tryParseFromLanguage_lc(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'c': return Language.LCC;
					case 'd': return Language.LCD;
					case 'e': return Language.LCE;
					case 'f': return Language.LCF;
					case 'h': return Language.LCH;
					case 'l': return Language.LCL;
					case 'm': return Language.LCM;
					case 'p': return Language.LCP;
					case 'q': return Language.LCQ;
					case 's': return Language.LCS;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ld(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.LDA;
					case 'b': return Language.LDB;
					case 'd': return Language.LDD;
					case 'g': return Language.LDG;
					case 'h': return Language.LDH;
					case 'i': return Language.LDI;
					case 'j': return Language.LDJ;
					case 'k': return Language.LDK;
					case 'l': return Language.LDL;
					case 'm': return Language.LDM;
					case 'n': return Language.LDN;
					case 'o': return Language.LDO;
					case 'p': return Language.LDP;
					case 'q': return Language.LDQ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_le(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.LEA;
					case 'b': return Language.LEB;
					case 'c': return Language.LEC;
					case 'd': return Language.LED;
					case 'e': return Language.LEE;
					case 'f': return Language.LEF;
					case 'g': return Language.LEG;
					case 'h': return Language.LEH;
					case 'i': return Language.LEI;
					case 'j': return Language.LEJ;
					case 'k': return Language.LEK;
					case 'l': return Language.LEL;
					case 'm': return Language.LEM;
					case 'n': return Language.LEN;
					case 'o': return Language.LEO;
					case 'p': return Language.LEP;
					case 'q': return Language.LEQ;
					case 'r': return Language.LER;
					case 's': return Language.LES;
					case 't': return Language.LET;
					case 'u': return Language.LEU;
					case 'v': return Language.LEV;
					case 'w': return Language.LEW;
					case 'x': return Language.LEX;
					case 'y': return Language.LEY;
					case 'z': return Language.LEZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_lf(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.LFA;
					case 'n': return Language.LFN;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_lh(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.LHA;
					case 'h': return Language.LHH;
					case 'i': return Language.LHI;
					case 'l': return Language.LHL;
					case 'm': return Language.LHM;
					case 'n': return Language.LHN;
					case 'p': return Language.LHP;
					case 's': return Language.LHS;
					case 't': return Language.LHT;
					case 'u': return Language.LHU;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_lj(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.LJA;
					case 'e': return Language.LJE;
					case 'i': return Language.LJI;
					case 'l': return Language.LJL;
					case 'p': return Language.LJP;
					case 'w': return Language.LJW;
					case 'x': return Language.LJX;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_lk(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.LKA;
					case 'b': return Language.LKB;
					case 'c': return Language.LKC;
					case 'd': return Language.LKD;
					case 'e': return Language.LKE;
					case 'h': return Language.LKH;
					case 'i': return Language.LKI;
					case 'j': return Language.LKJ;
					case 'l': return Language.LKL;
					case 'm': return Language.LKM;
					case 'n': return Language.LKN;
					case 'o': return Language.LKO;
					case 'r': return Language.LKR;
					case 's': return Language.LKS;
					case 't': return Language.LKT;
					case 'u': return Language.LKU;
					case 'y': return Language.LKY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ll(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.LLA;
					case 'b': return Language.LLB;
					case 'c': return Language.LLC;
					case 'd': return Language.LLD;
					case 'e': return Language.LLE;
					case 'f': return Language.LLF;
					case 'g': return Language.LLG;
					case 'h': return Language.LLH;
					case 'i': return Language.LLI;
					case 'j': return Language.LLJ;
					case 'k': return Language.LLK;
					case 'l': return Language.LLL;
					case 'm': return Language.LLM;
					case 'n': return Language.LLN;
					case 'o': return Language.LLO;
					case 'p': return Language.LLP;
					case 'q': return Language.LLQ;
					case 's': return Language.LLS;
					case 'u': return Language.LLU;
					case 'x': return Language.LLX;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_lm(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.LMA;
					case 'b': return Language.LMB;
					case 'c': return Language.LMC;
					case 'd': return Language.LMD;
					case 'e': return Language.LME;
					case 'f': return Language.LMF;
					case 'g': return Language.LMG;
					case 'h': return Language.LMH;
					case 'i': return Language.LMI;
					case 'j': return Language.LMJ;
					case 'k': return Language.LMK;
					case 'l': return Language.LML;
					case 'm': return Language.RMX;
					case 'n': return Language.LMN;
					case 'o': return Language.LMO;
					case 'p': return Language.LMP;
					case 'q': return Language.LMQ;
					case 'r': return Language.LMR;
					case 'u': return Language.LMU;
					case 'v': return Language.LMV;
					case 'w': return Language.LMW;
					case 'x': return Language.LMX;
					case 'y': return Language.LMY;
					case 'z': return Language.LMZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_lp(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.LPA;
					case 'e': return Language.LPE;
					case 'n': return Language.LPN;
					case 'o': return Language.LPO;
					case 'x': return Language.LPX;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_lr(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.LRA;
					case 'c': return Language.LRC;
					case 'e': return Language.LRE;
					case 'g': return Language.LRG;
					case 'i': return Language.LRI;
					case 'k': return Language.LRK;
					case 'l': return Language.LRL;
					case 'm': return Language.LRM;
					case 'n': return Language.LRN;
					case 'o': return Language.LRO;
					case 'r': return Language.LRR;
					case 't': return Language.LRT;
					case 'v': return Language.LRV;
					case 'z': return Language.LRZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ls(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.LSA;
					case 'd': return Language.LSD;
					case 'e': return Language.LSE;
					case 'g': return Language.LSG;
					case 'h': return Language.LSH;
					case 'i': return Language.LSI;
					case 'l': return Language.LSL;
					case 'm': return Language.LSM;
					case 'o': return Language.LSO;
					case 'p': return Language.LSP;
					case 'r': return Language.LSR;
					case 's': return Language.LSS;
					case 't': return Language.LST;
					case 'y': return Language.LSY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_lw(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.LWA;
					case 'e': return Language.LWE;
					case 'g': return Language.LWG;
					case 'h': return Language.LWH;
					case 'l': return Language.LWL;
					case 'm': return Language.LWM;
					case 'o': return Language.LWO;
					case 't': return Language.LWT;
					case 'u': return Language.LWU;
					case 'w': return Language.LWW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ly(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.LYA;
					case 'g': return Language.LYG;
					case 'n': return Language.LYN;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_lz(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'h': return Language.LZH;
					case 'l': return Language.LZL;
					case 'n': return Language.LZN;
					case 'z': return Language.LZZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_m(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'g': return tryParseFromLanguage_mg(text, ref offset);
					case 'h': return tryParseFromLanguage_mh(text, ref offset);
					case 'i': return tryParseFromLanguage_mi(text, ref offset);
					case 'k': return tryParseFromLanguage_mk(text, ref offset);
					case 'l': return tryParseFromLanguage_ml(text, ref offset);
					case 'n': return tryParseFromLanguage_mn(text, ref offset);
					case 'o': return tryParseFromLanguage_mo(text, ref offset);
					case 'r': return tryParseFromLanguage_mr(text, ref offset);
					case 's': return tryParseFromLanguage_ms(text, ref offset);
					case 't': return tryParseFromLanguage_mt(text, ref offset);
					case 'y': return tryParseFromLanguage_my(text, ref offset);
					case 'a': return tryParseFromLanguage_ma(text, ref offset);
					case 'b': return tryParseFromLanguage_mb(text, ref offset);
					case 'c': return tryParseFromLanguage_mc(text, ref offset);
					case 'd': return tryParseFromLanguage_md(text, ref offset);
					case 'e': return tryParseFromLanguage_me(text, ref offset);
					case 'f': return tryParseFromLanguage_mf(text, ref offset);
					case 'j': return tryParseFromLanguage_mj(text, ref offset);
					case 'm': return tryParseFromLanguage_mm(text, ref offset);
					case 'p': return tryParseFromLanguage_mp(text, ref offset);
					case 'q': return tryParseFromLanguage_mq(text, ref offset);
					case 'u': return tryParseFromLanguage_mu(text, ref offset);
					case 'v': return tryParseFromLanguage_mv(text, ref offset);
					case 'w': return tryParseFromLanguage_mw(text, ref offset);
					case 'x': return tryParseFromLanguage_mx(text, ref offset);
					case 'z': return tryParseFromLanguage_mz(text, ref offset);
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_mg(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.MGA;
					case 'b': return Language.MGB;
					case 'c': return Language.MGC;
					case 'd': return Language.MGD;
					case 'e': return Language.MGE;
					case 'f': return Language.MGF;
					case 'g': return Language.MGG;
					case 'h': return Language.MGH;
					case 'i': return Language.MGI;
					case 'j': return Language.MGJ;
					case 'k': return Language.MGK;
					case 'l': return Language.MGL;
					case 'm': return Language.MGM;
					case 'n': return Language.MGN;
					case 'o': return Language.MGO;
					case 'p': return Language.MGP;
					case 'q': return Language.MGQ;
					case 'r': return Language.MGR;
					case 's': return Language.MGS;
					case 't': return Language.MGT;
					case 'u': return Language.MGU;
					case 'v': return Language.MGV;
					case 'w': return Language.MGW;
					case 'x': return Language.MGX;
					case 'y': return Language.MGY;
					case 'z': return Language.MGZ;
				}
				offset--;
			}
			return Language.MG;
		}

		private static Language? tryParseFromLanguage_mh(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.MHA;
					case 'b': return Language.MHB;
					case 'c': return Language.MHC;
					case 'd': return Language.MHD;
					case 'e': return Language.MHE;
					case 'f': return Language.MHF;
					case 'g': return Language.MHG;
					case 'h': return Language.MHH;
					case 'i': return Language.MHI;
					case 'j': return Language.MHJ;
					case 'k': return Language.MHK;
					case 'l': return Language.MHL;
					case 'm': return Language.MHM;
					case 'n': return Language.MHN;
					case 'o': return Language.MHO;
					case 'p': return Language.MHP;
					case 'q': return Language.MHQ;
					case 'r': return Language.MHR;
					case 's': return Language.MHS;
					case 't': return Language.MHT;
					case 'u': return Language.MHU;
					case 'w': return Language.MHW;
					case 'x': return Language.MHX;
					case 'y': return Language.MHY;
					case 'z': return Language.MHZ;
				}
				offset--;
			}
			return Language.MH;
		}

		private static Language? tryParseFromLanguage_mi(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.MIA;
					case 'b': return Language.MIB;
					case 'c': return Language.MIC;
					case 'd': return Language.MID;
					case 'e': return Language.MIE;
					case 'f': return Language.MIF;
					case 'g': return Language.MIG;
					case 'h': return Language.MIH;
					case 'i': return Language.MII;
					case 'j': return Language.MIJ;
					case 'k': return Language.MIK;
					case 'l': return Language.MIL;
					case 'm': return Language.MIM;
					case 'n': return Language.MIN;
					case 'o': return Language.MIO;
					case 'p': return Language.MIP;
					case 'q': return Language.MIQ;
					case 'r': return Language.MIR;
					case 's': return Language.MIS;
					case 't': return Language.MIT;
					case 'u': return Language.MIU;
					case 'w': return Language.MIW;
					case 'x': return Language.MIX;
					case 'y': return Language.MIY;
					case 'z': return Language.MIZ;
				}
				offset--;
			}
			return Language.MI;
		}

		private static Language? tryParseFromLanguage_mk(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.MKA;
					case 'b': return Language.MKB;
					case 'c': return Language.MKC;
					case 'e': return Language.MKE;
					case 'f': return Language.MKF;
					case 'g': return Language.MKG;
					case 'h': return Language.MKH;
					case 'i': return Language.MKI;
					case 'j': return Language.MKJ;
					case 'k': return Language.MKK;
					case 'l': return Language.MKL;
					case 'm': return Language.MKM;
					case 'n': return Language.MKN;
					case 'o': return Language.MKO;
					case 'p': return Language.MKP;
					case 'q': return Language.MKQ;
					case 'r': return Language.MKR;
					case 's': return Language.MKS;
					case 't': return Language.MKT;
					case 'u': return Language.MKU;
					case 'v': return Language.MKV;
					case 'w': return Language.MKW;
					case 'x': return Language.MKX;
					case 'y': return Language.MKY;
					case 'z': return Language.MKZ;
				}
				offset--;
			}
			return Language.MK;
		}

		private static Language? tryParseFromLanguage_ml(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.MLA;
					case 'b': return Language.MLB;
					case 'c': return Language.MLC;
					case 'd': return Language.MLD;
					case 'e': return Language.MLE;
					case 'f': return Language.MLF;
					case 'h': return Language.MLH;
					case 'i': return Language.MLI;
					case 'j': return Language.MLJ;
					case 'k': return Language.MLK;
					case 'l': return Language.MLL;
					case 'm': return Language.MLM;
					case 'n': return Language.MLN;
					case 'o': return Language.MLO;
					case 'p': return Language.MLP;
					case 'q': return Language.MLQ;
					case 'r': return Language.MLR;
					case 's': return Language.MLS;
					case 'u': return Language.MLU;
					case 'v': return Language.MLV;
					case 'w': return Language.MLW;
					case 'x': return Language.MLX;
					case 'z': return Language.MLZ;
				}
				offset--;
			}
			return Language.ML;
		}

		private static Language? tryParseFromLanguage_mn(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.MNA;
					case 'b': return Language.MNB;
					case 'c': return Language.MNC;
					case 'd': return Language.MND;
					case 'e': return Language.MNE;
					case 'f': return Language.MNF;
					case 'g': return Language.MNG;
					case 'h': return Language.MNH;
					case 'i': return Language.MNI;
					case 'j': return Language.MNJ;
					case 'k': return Language.MNK;
					case 'l': return Language.MNL;
					case 'm': return Language.MNM;
					case 'n': return Language.MNN;
					case 'o': return Language.MNO;
					case 'p': return Language.MNP;
					case 'q': return Language.MNQ;
					case 'r': return Language.MNR;
					case 's': return Language.MNS;
					case 't': return Language.MNT;
					case 'u': return Language.MNU;
					case 'v': return Language.MNV;
					case 'w': return Language.MNW;
					case 'x': return Language.MNX;
					case 'y': return Language.MNY;
					case 'z': return Language.MNZ;
				}
				offset--;
			}
			return Language.MN;
		}

		private static Language? tryParseFromLanguage_mo(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.MOA;
					case 'c': return Language.MOC;
					case 'd': return Language.MOD;
					case 'e': return Language.MOE;
					case 'f': return Language.MOF;
					case 'g': return Language.MOG;
					case 'h': return Language.MOH;
					case 'i': return Language.MOI;
					case 'j': return Language.MOJ;
					case 'k': return Language.MOK;
					case 'm': return Language.MOM;
					case 'o': return Language.MOO;
					case 'p': return Language.MOP;
					case 'q': return Language.MOQ;
					case 'r': return Language.MOR;
					case 's': return Language.MOS;
					case 't': return Language.MOT;
					case 'u': return Language.MOU;
					case 'v': return Language.MOV;
					case 'w': return Language.MOW;
					case 'x': return Language.MOX;
					case 'y': return Language.MOY;
					case 'z': return Language.MOZ;
				}
				offset--;
			}
			return Language.RO;
		}

		private static Language? tryParseFromLanguage_mr(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.MRA;
					case 'b': return Language.MRB;
					case 'c': return Language.MRC;
					case 'd': return Language.MRD;
					case 'e': return Language.MRE;
					case 'f': return Language.MRF;
					case 'g': return Language.MRG;
					case 'h': return Language.MRH;
					case 'j': return Language.MRJ;
					case 'k': return Language.MRK;
					case 'l': return Language.MRL;
					case 'm': return Language.MRM;
					case 'n': return Language.MRN;
					case 'o': return Language.MRO;
					case 'p': return Language.MRP;
					case 'q': return Language.MRQ;
					case 'r': return Language.MRR;
					case 's': return Language.MRS;
					case 't': return Language.MRT;
					case 'u': return Language.MRU;
					case 'v': return Language.MRV;
					case 'w': return Language.MRW;
					case 'x': return Language.MRX;
					case 'y': return Language.MRY;
					case 'z': return Language.MRZ;
				}
				offset--;
			}
			return Language.MR;
		}

		private static Language? tryParseFromLanguage_ms(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.MSB;
					case 'c': return Language.MSC;
					case 'd': return Language.MSD;
					case 'e': return Language.MSE;
					case 'f': return Language.MSF;
					case 'g': return Language.MSG;
					case 'h': return Language.MSH;
					case 'i': return Language.MSI;
					case 'j': return Language.MSJ;
					case 'k': return Language.MSK;
					case 'l': return Language.MSL;
					case 'm': return Language.MSM;
					case 'n': return Language.MSN;
					case 'o': return Language.MSO;
					case 'p': return Language.MSP;
					case 'q': return Language.MSQ;
					case 'r': return Language.MSR;
					case 's': return Language.MSS;
					case 't': return Language.MRY;
					case 'u': return Language.MSU;
					case 'v': return Language.MSV;
					case 'w': return Language.MSW;
					case 'x': return Language.MSX;
					case 'y': return Language.MSY;
					case 'z': return Language.MSZ;
				}
				offset--;
			}
			return Language.MS;
		}

		private static Language? tryParseFromLanguage_mt(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.MTA;
					case 'b': return Language.MTB;
					case 'c': return Language.MTC;
					case 'd': return Language.MTD;
					case 'e': return Language.MTE;
					case 'f': return Language.MTF;
					case 'g': return Language.MTG;
					case 'h': return Language.MTH;
					case 'i': return Language.MTI;
					case 'j': return Language.MTJ;
					case 'k': return Language.MTK;
					case 'l': return Language.MTL;
					case 'm': return Language.MTM;
					case 'n': return Language.MTN;
					case 'o': return Language.MTO;
					case 'p': return Language.MTP;
					case 'q': return Language.MTQ;
					case 'r': return Language.MTR;
					case 's': return Language.MTS;
					case 't': return Language.MTT;
					case 'u': return Language.MTU;
					case 'v': return Language.MTV;
					case 'w': return Language.MTW;
					case 'x': return Language.MTX;
					case 'y': return Language.MTY;
				}
				offset--;
			}
			return Language.MT;
		}

		private static Language? tryParseFromLanguage_my(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.MYB;
					case 'c': return Language.MYC;
					case 'd': return Language.MYD;
					case 'e': return Language.MYE;
					case 'f': return Language.MYF;
					case 'g': return Language.MYG;
					case 'h': return Language.MYH;
					case 'i': return Language.MYI;
					case 'j': return Language.MYJ;
					case 'k': return Language.MYK;
					case 'l': return Language.MYL;
					case 'm': return Language.MYM;
					case 'n': return Language.MYN;
					case 'o': return Language.MYO;
					case 'p': return Language.MYP;
					case 'q': return Language.MYQ;
					case 'r': return Language.MYR;
					case 's': return Language.MYS;
					case 't': return Language.MRY;
					case 'u': return Language.MYU;
					case 'v': return Language.MYV;
					case 'w': return Language.MYW;
					case 'x': return Language.MYX;
					case 'y': return Language.MYY;
					case 'z': return Language.MYZ;
				}
				offset--;
			}
			return Language.MY;
		}

		private static Language? tryParseFromLanguage_ma(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.MAA;
					case 'b': return Language.MAB;
					case 'd': return Language.MAD;
					case 'e': return Language.MAE;
					case 'f': return Language.MAF;
					case 'g': return Language.MAG;
					case 'i': return Language.MAI;
					case 'j': return Language.MAJ;
					case 'k': return Language.MAK;
					case 'm': return Language.MAM;
					case 'n': return Language.MAN;
					case 'p': return Language.MAP;
					case 'q': return Language.MAQ;
					case 's': return Language.MAS;
					case 't': return Language.MAT;
					case 'u': return Language.MAU;
					case 'v': return Language.MAV;
					case 'w': return Language.MAW;
					case 'x': return Language.MAX;
					case 'z': return Language.MAZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_mb(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.MBA;
					case 'b': return Language.MBB;
					case 'c': return Language.MBC;
					case 'd': return Language.MBD;
					case 'e': return Language.MBE;
					case 'f': return Language.MBF;
					case 'h': return Language.MBH;
					case 'i': return Language.MBI;
					case 'j': return Language.MBJ;
					case 'k': return Language.MBK;
					case 'l': return Language.MBL;
					case 'm': return Language.MBM;
					case 'n': return Language.MBN;
					case 'o': return Language.MBO;
					case 'p': return Language.MBP;
					case 'q': return Language.MBQ;
					case 'r': return Language.MBR;
					case 's': return Language.MBS;
					case 't': return Language.MBT;
					case 'u': return Language.MBU;
					case 'v': return Language.MBV;
					case 'w': return Language.MBW;
					case 'x': return Language.MBX;
					case 'y': return Language.MBY;
					case 'z': return Language.MBZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_mc(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.MCA;
					case 'b': return Language.MCB;
					case 'c': return Language.MCC;
					case 'd': return Language.MCD;
					case 'e': return Language.MCE;
					case 'f': return Language.MCF;
					case 'g': return Language.MCG;
					case 'h': return Language.MCH;
					case 'i': return Language.MCI;
					case 'j': return Language.MCJ;
					case 'k': return Language.MCK;
					case 'l': return Language.MCL;
					case 'm': return Language.MCM;
					case 'n': return Language.MCN;
					case 'o': return Language.MCO;
					case 'p': return Language.MCP;
					case 'q': return Language.MCQ;
					case 'r': return Language.MCR;
					case 's': return Language.MCS;
					case 't': return Language.MCT;
					case 'u': return Language.MCU;
					case 'v': return Language.MCV;
					case 'w': return Language.MCW;
					case 'x': return Language.MCX;
					case 'y': return Language.MCY;
					case 'z': return Language.MCZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_md(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.MDA;
					case 'b': return Language.MDB;
					case 'c': return Language.MDC;
					case 'd': return Language.MDD;
					case 'e': return Language.MDE;
					case 'f': return Language.MDF;
					case 'g': return Language.MDG;
					case 'h': return Language.MDH;
					case 'i': return Language.MDI;
					case 'j': return Language.MDJ;
					case 'k': return Language.MDK;
					case 'l': return Language.MDL;
					case 'm': return Language.MDM;
					case 'n': return Language.MDN;
					case 'p': return Language.MDP;
					case 'q': return Language.MDQ;
					case 'r': return Language.MDR;
					case 's': return Language.MDS;
					case 't': return Language.MDT;
					case 'u': return Language.MDU;
					case 'v': return Language.MDV;
					case 'w': return Language.MDW;
					case 'x': return Language.MDX;
					case 'y': return Language.MDY;
					case 'z': return Language.MDZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_me(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.MEA;
					case 'b': return Language.MEB;
					case 'c': return Language.MEC;
					case 'd': return Language.MED;
					case 'e': return Language.MEE;
					case 'f': return Language.MEF;
					case 'g': return Language.CIR;
					case 'h': return Language.MEH;
					case 'i': return Language.MEI;
					case 'j': return Language.MEJ;
					case 'k': return Language.MEK;
					case 'l': return Language.MEL;
					case 'm': return Language.MEM;
					case 'n': return Language.MEN;
					case 'o': return Language.MEO;
					case 'p': return Language.MEP;
					case 'q': return Language.MEQ;
					case 'r': return Language.MER;
					case 's': return Language.MES;
					case 't': return Language.MET;
					case 'u': return Language.MEU;
					case 'v': return Language.MEV;
					case 'w': return Language.MEW;
					case 'y': return Language.MEY;
					case 'z': return Language.MEZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_mf(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.MFA;
					case 'b': return Language.MFB;
					case 'c': return Language.MFC;
					case 'd': return Language.MFD;
					case 'e': return Language.MFE;
					case 'f': return Language.MFF;
					case 'g': return Language.MFG;
					case 'h': return Language.MFH;
					case 'i': return Language.MFI;
					case 'j': return Language.MFJ;
					case 'k': return Language.MFK;
					case 'l': return Language.MFL;
					case 'm': return Language.MFM;
					case 'n': return Language.MFN;
					case 'o': return Language.MFO;
					case 'p': return Language.MFP;
					case 'q': return Language.MFQ;
					case 'r': return Language.MFR;
					case 's': return Language.MFS;
					case 't': return Language.MFT;
					case 'u': return Language.MFU;
					case 'v': return Language.MFV;
					case 'w': return Language.MFW;
					case 'x': return Language.MFX;
					case 'y': return Language.MFY;
					case 'z': return Language.MFZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_mj(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.MJA;
					case 'b': return Language.MJB;
					case 'c': return Language.MJC;
					case 'd': return Language.MJD;
					case 'e': return Language.MJE;
					case 'g': return Language.MJG;
					case 'h': return Language.MJH;
					case 'i': return Language.MJI;
					case 'j': return Language.MJJ;
					case 'k': return Language.MJK;
					case 'l': return Language.MJL;
					case 'm': return Language.MJM;
					case 'n': return Language.MJN;
					case 'o': return Language.MJO;
					case 'p': return Language.MJP;
					case 'q': return Language.MJQ;
					case 'r': return Language.MJR;
					case 's': return Language.MJS;
					case 't': return Language.MJT;
					case 'u': return Language.MJU;
					case 'v': return Language.MJV;
					case 'w': return Language.MJW;
					case 'x': return Language.MJX;
					case 'y': return Language.MJY;
					case 'z': return Language.MJZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_mm(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.MMA;
					case 'b': return Language.MMB;
					case 'c': return Language.MMC;
					case 'd': return Language.MMD;
					case 'e': return Language.MME;
					case 'f': return Language.MMF;
					case 'g': return Language.MMG;
					case 'h': return Language.MMH;
					case 'i': return Language.MMI;
					case 'j': return Language.MMJ;
					case 'k': return Language.MMK;
					case 'l': return Language.MML;
					case 'm': return Language.MMM;
					case 'n': return Language.MMN;
					case 'o': return Language.MMO;
					case 'p': return Language.MMP;
					case 'q': return Language.MMQ;
					case 'r': return Language.MMR;
					case 't': return Language.MMT;
					case 'u': return Language.MMU;
					case 'v': return Language.MMV;
					case 'w': return Language.MMW;
					case 'x': return Language.MMX;
					case 'y': return Language.MMY;
					case 'z': return Language.MMZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_mp(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.MPA;
					case 'b': return Language.MPB;
					case 'c': return Language.MPC;
					case 'd': return Language.MPD;
					case 'e': return Language.MPE;
					case 'g': return Language.MPG;
					case 'h': return Language.MPH;
					case 'i': return Language.MPI;
					case 'j': return Language.MPJ;
					case 'k': return Language.MPK;
					case 'l': return Language.MPL;
					case 'm': return Language.MPM;
					case 'n': return Language.MPN;
					case 'o': return Language.MPO;
					case 'p': return Language.MPP;
					case 'q': return Language.MPQ;
					case 'r': return Language.MPR;
					case 's': return Language.MPS;
					case 't': return Language.MPT;
					case 'u': return Language.MPU;
					case 'v': return Language.MPV;
					case 'w': return Language.MPW;
					case 'x': return Language.MPX;
					case 'y': return Language.MPY;
					case 'z': return Language.MPZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_mq(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.MQA;
					case 'b': return Language.MQB;
					case 'c': return Language.MQC;
					case 'e': return Language.MQE;
					case 'f': return Language.MQF;
					case 'g': return Language.MQG;
					case 'h': return Language.MQH;
					case 'i': return Language.MQI;
					case 'j': return Language.MQJ;
					case 'k': return Language.MQK;
					case 'l': return Language.MQL;
					case 'm': return Language.MQM;
					case 'n': return Language.MQN;
					case 'o': return Language.MQO;
					case 'p': return Language.MQP;
					case 'q': return Language.MQQ;
					case 'r': return Language.MQR;
					case 's': return Language.MQS;
					case 't': return Language.MQT;
					case 'u': return Language.MQU;
					case 'v': return Language.MQV;
					case 'w': return Language.MQW;
					case 'x': return Language.MQX;
					case 'y': return Language.MQY;
					case 'z': return Language.MQZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_mu(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.MUA;
					case 'b': return Language.MUB;
					case 'c': return Language.MUC;
					case 'd': return Language.MUD;
					case 'e': return Language.MUE;
					case 'g': return Language.MUG;
					case 'h': return Language.MUH;
					case 'i': return Language.MUI;
					case 'j': return Language.MUJ;
					case 'k': return Language.MUK;
					case 'l': return Language.MUL;
					case 'm': return Language.MUM;
					case 'n': return Language.MUN;
					case 'o': return Language.MUO;
					case 'p': return Language.MUP;
					case 'q': return Language.MUQ;
					case 'r': return Language.MUR;
					case 's': return Language.MUS;
					case 't': return Language.MUT;
					case 'u': return Language.MUU;
					case 'v': return Language.MUV;
					case 'x': return Language.MUX;
					case 'y': return Language.MUY;
					case 'z': return Language.MUZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_mv(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.MVA;
					case 'b': return Language.MVB;
					case 'd': return Language.MVD;
					case 'e': return Language.MVE;
					case 'f': return Language.MVF;
					case 'g': return Language.MVG;
					case 'h': return Language.MVH;
					case 'i': return Language.MVI;
					case 'k': return Language.MVK;
					case 'l': return Language.MVL;
					case 'm': return Language.MVM;
					case 'n': return Language.MVN;
					case 'o': return Language.MVO;
					case 'p': return Language.MVP;
					case 'q': return Language.MVQ;
					case 'r': return Language.MVR;
					case 's': return Language.MVS;
					case 't': return Language.MVT;
					case 'u': return Language.MVU;
					case 'v': return Language.MVV;
					case 'w': return Language.MVW;
					case 'x': return Language.MVX;
					case 'y': return Language.MVY;
					case 'z': return Language.MVZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_mw(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.MWA;
					case 'b': return Language.MWB;
					case 'c': return Language.MWC;
					case 'd': return Language.MWD;
					case 'e': return Language.MWE;
					case 'f': return Language.MWF;
					case 'g': return Language.MWG;
					case 'h': return Language.MWH;
					case 'i': return Language.MWI;
					case 'j': return Language.VAJ;
					case 'k': return Language.MWK;
					case 'l': return Language.MWL;
					case 'm': return Language.MWM;
					case 'n': return Language.MWN;
					case 'o': return Language.MWO;
					case 'p': return Language.MWP;
					case 'q': return Language.MWQ;
					case 'r': return Language.MWR;
					case 's': return Language.MWS;
					case 't': return Language.MWT;
					case 'u': return Language.MWU;
					case 'v': return Language.MWV;
					case 'w': return Language.MWW;
					case 'x': return Language.MWX;
					case 'y': return Language.MWY;
					case 'z': return Language.MWZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_mx(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.MXA;
					case 'b': return Language.MXB;
					case 'c': return Language.MXC;
					case 'd': return Language.MXD;
					case 'e': return Language.MXE;
					case 'f': return Language.MXF;
					case 'g': return Language.MXG;
					case 'h': return Language.MXH;
					case 'i': return Language.MXI;
					case 'j': return Language.MXJ;
					case 'k': return Language.MXK;
					case 'l': return Language.MXL;
					case 'm': return Language.MXM;
					case 'n': return Language.MXN;
					case 'o': return Language.MXO;
					case 'p': return Language.MXP;
					case 'q': return Language.MXQ;
					case 'r': return Language.MXR;
					case 's': return Language.MXS;
					case 't': return Language.MXT;
					case 'u': return Language.MXU;
					case 'v': return Language.MXV;
					case 'w': return Language.MXW;
					case 'x': return Language.MXX;
					case 'y': return Language.MXY;
					case 'z': return Language.MXZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_mz(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.MZA;
					case 'b': return Language.MZB;
					case 'c': return Language.MZC;
					case 'd': return Language.MZD;
					case 'e': return Language.MZE;
					case 'g': return Language.MZG;
					case 'h': return Language.MZH;
					case 'i': return Language.MZI;
					case 'j': return Language.MZJ;
					case 'k': return Language.MZK;
					case 'l': return Language.MZL;
					case 'm': return Language.MZM;
					case 'n': return Language.MZN;
					case 'o': return Language.MZO;
					case 'p': return Language.MZP;
					case 'q': return Language.MZQ;
					case 'r': return Language.MZR;
					case 's': return Language.MZS;
					case 't': return Language.MZT;
					case 'u': return Language.MZU;
					case 'v': return Language.MZV;
					case 'w': return Language.MZW;
					case 'x': return Language.MZX;
					case 'y': return Language.MZY;
					case 'z': return Language.MZZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_n(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return tryParseFromLanguage_na(text, ref offset);
					case 'b': return tryParseFromLanguage_nb(text, ref offset);
					case 'd': return tryParseFromLanguage_nd(text, ref offset);
					case 'e': return tryParseFromLanguage_ne(text, ref offset);
					case 'g': return tryParseFromLanguage_ng(text, ref offset);
					case 'l': return tryParseFromLanguage_nl(text, ref offset);
					case 'n': return tryParseFromLanguage_nn(text, ref offset);
					case 'o': return tryParseFromLanguage_no(text, ref offset);
					case 'r': return tryParseFromLanguage_nr(text, ref offset);
					case 'v': return tryParseFromLanguage_nv(text, ref offset);
					case 'y': return tryParseFromLanguage_ny(text, ref offset);
					case 'c': return tryParseFromLanguage_nc(text, ref offset);
					case 'f': return tryParseFromLanguage_nf(text, ref offset);
					case 'h': return tryParseFromLanguage_nh(text, ref offset);
					case 'i': return tryParseFromLanguage_ni(text, ref offset);
					case 'j': return tryParseFromLanguage_nj(text, ref offset);
					case 'k': return tryParseFromLanguage_nk(text, ref offset);
					case 'm': return tryParseFromLanguage_nm(text, ref offset);
					case 'p': return tryParseFromLanguage_np(text, ref offset);
					case 'q': return tryParseFromLanguage_nq(text, ref offset);
					case 's': return tryParseFromLanguage_ns(text, ref offset);
					case 't': return tryParseFromLanguage_nt(text, ref offset);
					case 'u': return tryParseFromLanguage_nu(text, ref offset);
					case 'w': return tryParseFromLanguage_nw(text, ref offset);
					case 'x': return tryParseFromLanguage_nx(text, ref offset);
					case 'z': return tryParseFromLanguage_nz(text, ref offset);
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_na(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.NAA;
					case 'b': return Language.NAB;
					case 'c': return Language.NAC;
					case 'd': return Language.XNY;
					case 'e': return Language.NAE;
					case 'f': return Language.NAF;
					case 'g': return Language.NAG;
					case 'h': return Language.NAH;
					case 'i': return Language.NAI;
					case 'j': return Language.NAJ;
					case 'k': return Language.NAK;
					case 'l': return Language.NAL;
					case 'm': return Language.NAM;
					case 'n': return Language.NAN;
					case 'o': return Language.NAO;
					case 'p': return Language.NAP;
					case 'q': return Language.NAQ;
					case 'r': return Language.NAR;
					case 's': return Language.NAS;
					case 't': return Language.NAT;
					case 'w': return Language.NAW;
					case 'x': return Language.NAX;
					case 'y': return Language.NAY;
					case 'z': return Language.NAZ;
				}
				offset--;
			}
			return Language.NA;
		}

		private static Language? tryParseFromLanguage_nb(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.NBA;
					case 'b': return Language.NBB;
					case 'c': return Language.NBC;
					case 'd': return Language.NBD;
					case 'e': return Language.NBE;
					case 'f': return Language.NBF;
					case 'g': return Language.NBG;
					case 'h': return Language.NBH;
					case 'i': return Language.NBI;
					case 'j': return Language.NBJ;
					case 'k': return Language.NBK;
					case 'm': return Language.NBM;
					case 'n': return Language.NBN;
					case 'o': return Language.NBO;
					case 'p': return Language.NBP;
					case 'q': return Language.NBQ;
					case 'r': return Language.NBR;
					case 's': return Language.NBS;
					case 't': return Language.NBT;
					case 'u': return Language.NBU;
					case 'v': return Language.NBV;
					case 'w': return Language.NBW;
					case 'x': return Language.NBX;
					case 'y': return Language.NBY;
				}
				offset--;
			}
			return Language.NB;
		}

		private static Language? tryParseFromLanguage_nd(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.NDA;
					case 'b': return Language.NDB;
					case 'c': return Language.NDC;
					case 'd': return Language.NDD;
					case 'f': return Language.NDF;
					case 'g': return Language.NDG;
					case 'h': return Language.NDH;
					case 'i': return Language.NDI;
					case 'j': return Language.NDJ;
					case 'k': return Language.NDK;
					case 'l': return Language.NDL;
					case 'm': return Language.NDM;
					case 'n': return Language.NDN;
					case 'p': return Language.NDP;
					case 'q': return Language.NDQ;
					case 'r': return Language.NDR;
					case 's': return Language.NDS;
					case 't': return Language.NDT;
					case 'u': return Language.NDU;
					case 'v': return Language.NDV;
					case 'w': return Language.NDW;
					case 'x': return Language.NDX;
					case 'y': return Language.NDY;
					case 'z': return Language.NDZ;
				}
				offset--;
			}
			return Language.ND;
		}

		private static Language? tryParseFromLanguage_ne(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.NEA;
					case 'b': return Language.NEB;
					case 'c': return Language.NEC;
					case 'd': return Language.NED;
					case 'e': return Language.NEE;
					case 'f': return Language.NEF;
					case 'g': return Language.NEG;
					case 'h': return Language.NEH;
					case 'i': return Language.NEI;
					case 'j': return Language.NEJ;
					case 'k': return Language.NEK;
					case 'm': return Language.NEM;
					case 'n': return Language.NEN;
					case 'o': return Language.NEO;
					case 'q': return Language.NEQ;
					case 'r': return Language.NER;
					case 's': return Language.NES;
					case 't': return Language.NET;
					case 'u': return Language.NEU;
					case 'v': return Language.NEV;
					case 'w': return Language.NEW;
					case 'x': return Language.NEX;
					case 'y': return Language.NEY;
					case 'z': return Language.NEZ;
				}
				offset--;
			}
			return Language.NE;
		}

		private static Language? tryParseFromLanguage_ng(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.NGA;
					case 'b': return Language.NGB;
					case 'c': return Language.NGC;
					case 'd': return Language.NGD;
					case 'e': return Language.NGE;
					case 'f': return Language.NGF;
					case 'g': return Language.NGG;
					case 'h': return Language.NGH;
					case 'i': return Language.NGI;
					case 'j': return Language.NGJ;
					case 'k': return Language.NGK;
					case 'l': return Language.NGL;
					case 'm': return Language.NGM;
					case 'n': return Language.NGN;
					case 'o': return Language.NGO;
					case 'p': return Language.NGP;
					case 'q': return Language.NGQ;
					case 'r': return Language.NGR;
					case 's': return Language.NGS;
					case 't': return Language.NGT;
					case 'u': return Language.NGU;
					case 'v': return Language.NGV;
					case 'w': return Language.NGW;
					case 'x': return Language.NGX;
					case 'y': return Language.NGY;
					case 'z': return Language.NGZ;
				}
				offset--;
			}
			return Language.NG;
		}

		private static Language? tryParseFromLanguage_nl(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.NLA;
					case 'c': return Language.NLC;
					case 'e': return Language.NLE;
					case 'g': return Language.NLG;
					case 'i': return Language.NLI;
					case 'j': return Language.NLJ;
					case 'k': return Language.NLK;
					case 'l': return Language.NLL;
					case 'n': return Language.NLN;
					case 'o': return Language.NLO;
					case 'q': return Language.NLQ;
					case 'r': return Language.NLR;
					case 'u': return Language.NLU;
					case 'v': return Language.NLV;
					case 'w': return Language.NLW;
					case 'x': return Language.NLX;
					case 'y': return Language.NLY;
					case 'z': return Language.NLZ;
				}
				offset--;
			}
			return Language.NL;
		}

		private static Language? tryParseFromLanguage_nn(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.NNA;
					case 'b': return Language.NNB;
					case 'c': return Language.NNC;
					case 'd': return Language.NND;
					case 'e': return Language.NNE;
					case 'f': return Language.NNF;
					case 'g': return Language.NNG;
					case 'h': return Language.NNH;
					case 'i': return Language.NNI;
					case 'j': return Language.NNJ;
					case 'k': return Language.NNK;
					case 'l': return Language.NNL;
					case 'm': return Language.NNM;
					case 'n': return Language.NNN;
					case 'p': return Language.NNP;
					case 'q': return Language.NNQ;
					case 'r': return Language.NNR;
					case 's': return Language.NNS;
					case 't': return Language.NNT;
					case 'u': return Language.NNU;
					case 'v': return Language.NNV;
					case 'w': return Language.NNW;
					case 'x': return Language.NGV;
					case 'y': return Language.NNY;
					case 'z': return Language.NNZ;
				}
				offset--;
			}
			return Language.NN;
		}

		private static Language? tryParseFromLanguage_no(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.NOA;
					case 'c': return Language.NOC;
					case 'd': return Language.NOD;
					case 'e': return Language.NOE;
					case 'f': return Language.NOF;
					case 'g': return Language.NOG;
					case 'h': return Language.NOH;
					case 'i': return Language.NOI;
					case 'j': return Language.NOJ;
					case 'k': return Language.NOK;
					case 'l': return Language.NOL;
					case 'm': return Language.NOM;
					case 'n': return Language.NON;
					case 'o': return Language.NOO;
					case 'p': return Language.NOP;
					case 'q': return Language.NOQ;
					case 's': return Language.NOS;
					case 't': return Language.NOT;
					case 'u': return Language.NOU;
					case 'v': return Language.NOV;
					case 'w': return Language.NOW;
					case 'y': return Language.NOY;
					case 'z': return Language.NOZ;
				}
				offset--;
			}
			return Language.NO;
		}

		private static Language? tryParseFromLanguage_nr(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.NRA;
					case 'b': return Language.NRB;
					case 'c': return Language.NRC;
					case 'e': return Language.NRE;
					case 'f': return Language.NRF;
					case 'g': return Language.NRG;
					case 'i': return Language.NRI;
					case 'k': return Language.NRK;
					case 'l': return Language.NRL;
					case 'm': return Language.NRM;
					case 'n': return Language.NRN;
					case 'p': return Language.NRP;
					case 'r': return Language.NRR;
					case 't': return Language.NRT;
					case 'u': return Language.NRU;
					case 'x': return Language.NRX;
					case 'z': return Language.NRZ;
				}
				offset--;
			}
			return Language.NR;
		}

		private static Language? tryParseFromLanguage_nv(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'h': return Language.NVH;
					case 'm': return Language.NVM;
					case 'o': return Language.NVO;
				}
				offset--;
			}
			return Language.NV;
		}

		private static Language? tryParseFromLanguage_ny(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.NYB;
					case 'c': return Language.NYC;
					case 'd': return Language.NYD;
					case 'e': return Language.NYE;
					case 'f': return Language.NYF;
					case 'g': return Language.NYG;
					case 'h': return Language.NYH;
					case 'i': return Language.NYI;
					case 'j': return Language.NYJ;
					case 'k': return Language.NYK;
					case 'l': return Language.NYL;
					case 'm': return Language.NYM;
					case 'n': return Language.NYN;
					case 'o': return Language.NYO;
					case 'p': return Language.NYP;
					case 'q': return Language.NYQ;
					case 'r': return Language.NYR;
					case 's': return Language.NYS;
					case 't': return Language.NYT;
					case 'u': return Language.NYU;
					case 'v': return Language.NYV;
					case 'w': return Language.NYW;
					case 'x': return Language.NYX;
					case 'y': return Language.NYY;
				}
				offset--;
			}
			return Language.NY;
		}

		private static Language? tryParseFromLanguage_nc(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.NCA;
					case 'b': return Language.NCB;
					case 'c': return Language.NCC;
					case 'd': return Language.NCD;
					case 'e': return Language.NCE;
					case 'f': return Language.NCF;
					case 'g': return Language.NCG;
					case 'h': return Language.NCH;
					case 'i': return Language.NCI;
					case 'j': return Language.NCJ;
					case 'k': return Language.NCK;
					case 'l': return Language.NCL;
					case 'm': return Language.NCM;
					case 'n': return Language.NCN;
					case 'o': return Language.NCO;
					case 'p': return Language.NCP;
					case 'r': return Language.NCR;
					case 's': return Language.NCS;
					case 't': return Language.NCT;
					case 'u': return Language.NCU;
					case 'x': return Language.NCX;
					case 'z': return Language.NCZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_nf(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.NFA;
					case 'd': return Language.NFD;
					case 'l': return Language.NFL;
					case 'r': return Language.NFR;
					case 'u': return Language.NFU;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_nh(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.NHA;
					case 'b': return Language.NHB;
					case 'c': return Language.NHC;
					case 'd': return Language.NHD;
					case 'e': return Language.NHE;
					case 'f': return Language.NHF;
					case 'g': return Language.NHG;
					case 'h': return Language.NHH;
					case 'i': return Language.NHI;
					case 'k': return Language.NHK;
					case 'm': return Language.NHM;
					case 'n': return Language.NHN;
					case 'o': return Language.NHO;
					case 'p': return Language.NHP;
					case 'q': return Language.NHQ;
					case 'r': return Language.NHR;
					case 't': return Language.NHT;
					case 'u': return Language.NHU;
					case 'v': return Language.NHV;
					case 'w': return Language.NHW;
					case 'x': return Language.NHX;
					case 'y': return Language.NHY;
					case 'z': return Language.NHZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ni(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.NIA;
					case 'b': return Language.NIB;
					case 'c': return Language.NIC;
					case 'd': return Language.NID;
					case 'e': return Language.NIE;
					case 'f': return Language.NIF;
					case 'g': return Language.NIG;
					case 'h': return Language.NIH;
					case 'i': return Language.NII;
					case 'j': return Language.NIJ;
					case 'k': return Language.NIK;
					case 'l': return Language.NIL;
					case 'm': return Language.NIM;
					case 'n': return Language.NIN;
					case 'o': return Language.NIO;
					case 'q': return Language.NIQ;
					case 'r': return Language.NIR;
					case 's': return Language.NIS;
					case 't': return Language.NIT;
					case 'u': return Language.NIU;
					case 'v': return Language.NIV;
					case 'w': return Language.NIW;
					case 'x': return Language.NIX;
					case 'y': return Language.NIY;
					case 'z': return Language.NIZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_nj(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.NJA;
					case 'b': return Language.NJB;
					case 'd': return Language.NJD;
					case 'h': return Language.NJH;
					case 'i': return Language.NJI;
					case 'j': return Language.NJJ;
					case 'l': return Language.NJL;
					case 'm': return Language.NJM;
					case 'n': return Language.NJN;
					case 'o': return Language.NJO;
					case 'r': return Language.NJR;
					case 's': return Language.NJS;
					case 't': return Language.NJT;
					case 'u': return Language.NJU;
					case 'x': return Language.NJX;
					case 'y': return Language.NJY;
					case 'z': return Language.NJZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_nk(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.NKA;
					case 'b': return Language.NKB;
					case 'c': return Language.NKC;
					case 'd': return Language.NKD;
					case 'e': return Language.NKE;
					case 'f': return Language.NKF;
					case 'g': return Language.NKG;
					case 'h': return Language.NKH;
					case 'i': return Language.NKI;
					case 'j': return Language.NKJ;
					case 'k': return Language.NKK;
					case 'm': return Language.NKM;
					case 'n': return Language.NKN;
					case 'o': return Language.NKO;
					case 'p': return Language.NKP;
					case 'q': return Language.NKQ;
					case 'r': return Language.NKR;
					case 's': return Language.NKS;
					case 't': return Language.NKT;
					case 'u': return Language.NKU;
					case 'v': return Language.NKV;
					case 'w': return Language.NKW;
					case 'x': return Language.NKX;
					case 'z': return Language.NKZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_nm(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.NMA;
					case 'b': return Language.NMB;
					case 'c': return Language.NMC;
					case 'd': return Language.NMD;
					case 'e': return Language.NME;
					case 'f': return Language.NMF;
					case 'g': return Language.NMG;
					case 'h': return Language.NMH;
					case 'i': return Language.NMI;
					case 'j': return Language.NMJ;
					case 'k': return Language.NMK;
					case 'l': return Language.NML;
					case 'm': return Language.NMM;
					case 'n': return Language.NMN;
					case 'o': return Language.NMO;
					case 'p': return Language.NMP;
					case 'q': return Language.NMQ;
					case 'r': return Language.NMR;
					case 's': return Language.NMS;
					case 't': return Language.NMT;
					case 'u': return Language.NMU;
					case 'v': return Language.NMV;
					case 'w': return Language.NMW;
					case 'x': return Language.NMX;
					case 'y': return Language.NMY;
					case 'z': return Language.NMZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_np(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.NPA;
					case 'b': return Language.NPB;
					case 'g': return Language.NPG;
					case 'h': return Language.NPH;
					case 'i': return Language.NPI;
					case 'l': return Language.NPL;
					case 'n': return Language.NPN;
					case 'o': return Language.NPO;
					case 's': return Language.NPS;
					case 'u': return Language.NPU;
					case 'y': return Language.NPY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_nq(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'g': return Language.NQG;
					case 'k': return Language.NQK;
					case 'm': return Language.NQM;
					case 'n': return Language.NQN;
					case 'o': return Language.NQO;
					case 'q': return Language.NQQ;
					case 'y': return Language.NQY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ns(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.NSA;
					case 'c': return Language.NSC;
					case 'd': return Language.NSD;
					case 'e': return Language.NSE;
					case 'f': return Language.NSF;
					case 'g': return Language.NSG;
					case 'h': return Language.NSH;
					case 'i': return Language.NSI;
					case 'k': return Language.NSK;
					case 'l': return Language.NSL;
					case 'm': return Language.NSM;
					case 'n': return Language.NSN;
					case 'o': return Language.NSO;
					case 'p': return Language.NSP;
					case 'q': return Language.NSQ;
					case 'r': return Language.NSR;
					case 's': return Language.NSS;
					case 't': return Language.NST;
					case 'u': return Language.NSU;
					case 'v': return Language.NSV;
					case 'w': return Language.NSW;
					case 'x': return Language.NSX;
					case 'y': return Language.NSY;
					case 'z': return Language.NSZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_nt(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'd': return Language.NTD;
					case 'e': return Language.NTE;
					case 'g': return Language.NTG;
					case 'i': return Language.NTI;
					case 'j': return Language.NTJ;
					case 'k': return Language.NTK;
					case 'm': return Language.NTM;
					case 'o': return Language.NTO;
					case 'p': return Language.NTP;
					case 'r': return Language.NTR;
					case 's': return Language.PIJ;
					case 'u': return Language.NTU;
					case 'w': return Language.NTW;
					case 'x': return Language.NTX;
					case 'y': return Language.NTY;
					case 'z': return Language.NTZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_nu(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.NUA;
					case 'b': return Language.NUB;
					case 'c': return Language.NUC;
					case 'd': return Language.NUD;
					case 'e': return Language.NUE;
					case 'f': return Language.NUF;
					case 'g': return Language.NUG;
					case 'h': return Language.NUH;
					case 'i': return Language.NUI;
					case 'j': return Language.NUJ;
					case 'k': return Language.NUK;
					case 'l': return Language.NUL;
					case 'm': return Language.NUM;
					case 'n': return Language.NUN;
					case 'o': return Language.NUO;
					case 'p': return Language.NUP;
					case 'q': return Language.NUQ;
					case 'r': return Language.NUR;
					case 's': return Language.NUS;
					case 't': return Language.NUT;
					case 'u': return Language.NUU;
					case 'v': return Language.NUV;
					case 'w': return Language.NUW;
					case 'x': return Language.NUX;
					case 'y': return Language.NUY;
					case 'z': return Language.NUZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_nw(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.NWA;
					case 'b': return Language.NWB;
					case 'c': return Language.NWC;
					case 'e': return Language.NWE;
					case 'g': return Language.NWG;
					case 'i': return Language.NWI;
					case 'm': return Language.NWM;
					case 'o': return Language.NWO;
					case 'r': return Language.NWR;
					case 'x': return Language.NWX;
					case 'y': return Language.NWY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_nx(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.NXA;
					case 'd': return Language.NXD;
					case 'e': return Language.NXE;
					case 'g': return Language.NXG;
					case 'i': return Language.NXI;
					case 'k': return Language.NXK;
					case 'l': return Language.NXL;
					case 'm': return Language.NXM;
					case 'n': return Language.NXN;
					case 'o': return Language.NXO;
					case 'q': return Language.NXQ;
					case 'r': return Language.NXR;
					case 'u': return Language.NXU;
					case 'x': return Language.NXX;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_nz(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.NZA;
					case 'b': return Language.NZB;
					case 'i': return Language.NZI;
					case 'k': return Language.NZK;
					case 'm': return Language.NZM;
					case 's': return Language.NZS;
					case 'u': return Language.NZU;
					case 'y': return Language.NZY;
					case 'z': return Language.NZZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_o(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'c': return tryParseFromLanguage_oc(text, ref offset);
					case 'j': return tryParseFromLanguage_oj(text, ref offset);
					case 'm': return tryParseFromLanguage_om(text, ref offset);
					case 'r': return tryParseFromLanguage_or(text, ref offset);
					case 's': return tryParseFromLanguage_os(text, ref offset);
					case 'a': return tryParseFromLanguage_oa(text, ref offset);
					case 'b': return tryParseFromLanguage_ob(text, ref offset);
					case 'd': return tryParseFromLanguage_od(text, ref offset);
					case 'f': return tryParseFromLanguage_of(text, ref offset);
					case 'g': return tryParseFromLanguage_og(text, ref offset);
					case 'h': return tryParseFromLanguage_oh(text, ref offset);
					case 'i': return tryParseFromLanguage_oi(text, ref offset);
					case 'k': return tryParseFromLanguage_ok(text, ref offset);
					case 'l': return tryParseFromLanguage_ol(text, ref offset);
					case 'n': return tryParseFromLanguage_on(text, ref offset);
					case 'o': return tryParseFromLanguage_oo(text, ref offset);
					case 'p': return tryParseFromLanguage_op(text, ref offset);
					case 't': return tryParseFromLanguage_ot(text, ref offset);
					case 'u': return tryParseFromLanguage_ou(text, ref offset);
					case 'v': return tryParseFromLanguage_ov(text, ref offset);
					case 'w': return tryParseFromLanguage_ow(text, ref offset);
					case 'y': return tryParseFromLanguage_oy(text, ref offset);
					case 'z': return tryParseFromLanguage_oz(text, ref offset);
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_oc(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.OCA;
					case 'h': return Language.OCH;
					case 'o': return Language.OCO;
					case 'u': return Language.OCU;
				}
				offset--;
			}
			return Language.OC;
		}

		private static Language? tryParseFromLanguage_oj(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.OJB;
					case 'c': return Language.OJC;
					case 'g': return Language.OJG;
					case 'p': return Language.OJP;
					case 's': return Language.OJS;
					case 'v': return Language.OJV;
					case 'w': return Language.OJW;
				}
				offset--;
			}
			return Language.OJ;
		}

		private static Language? tryParseFromLanguage_om(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.OMA;
					case 'b': return Language.OMB;
					case 'c': return Language.OMC;
					case 'e': return Language.OME;
					case 'g': return Language.OMG;
					case 'i': return Language.OMI;
					case 'k': return Language.OMK;
					case 'l': return Language.OML;
					case 'n': return Language.OMN;
					case 'o': return Language.OMO;
					case 'p': return Language.OMP;
					case 'q': return Language.OMQ;
					case 'r': return Language.OMR;
					case 't': return Language.OMT;
					case 'u': return Language.OMU;
					case 'v': return Language.OMV;
					case 'w': return Language.OMW;
					case 'x': return Language.OMX;
				}
				offset--;
			}
			return Language.OM;
		}

		private static Language? tryParseFromLanguage_or(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.ORA;
					case 'c': return Language.ORC;
					case 'e': return Language.ORE;
					case 'g': return Language.ORG;
					case 'h': return Language.ORH;
					case 'n': return Language.ORN;
					case 'o': return Language.ORO;
					case 'r': return Language.ORR;
					case 's': return Language.ORS;
					case 't': return Language.ORT;
					case 'u': return Language.ORU;
					case 'v': return Language.ORV;
					case 'w': return Language.ORW;
					case 'x': return Language.ORX;
					case 'y': return Language.ORY;
					case 'z': return Language.ORZ;
				}
				offset--;
			}
			return Language.OR;
		}

		private static Language? tryParseFromLanguage_os(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.OSA;
					case 'c': return Language.OSC;
					case 'i': return Language.OSI;
					case 'o': return Language.OSO;
					case 'p': return Language.OSP;
					case 't': return Language.OST;
					case 'u': return Language.OSU;
					case 'x': return Language.OSX;
				}
				offset--;
			}
			return Language.OS;
		}

		private static Language? tryParseFromLanguage_oa(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.OAA;
					case 'c': return Language.OAC;
					case 'r': return Language.OAR;
					case 'v': return Language.OAV;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ob(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'i': return Language.OBI;
					case 'k': return Language.OBK;
					case 'l': return Language.OBL;
					case 'm': return Language.OBM;
					case 'o': return Language.OBO;
					case 'r': return Language.OBR;
					case 't': return Language.OBT;
					case 'u': return Language.OBU;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_od(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.ODA;
					case 'k': return Language.ODK;
					case 't': return Language.ODT;
					case 'u': return Language.ODU;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_of(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'o': return Language.OFO;
					case 's': return Language.OFS;
					case 'u': return Language.OFU;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_og(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.OGB;
					case 'c': return Language.OGC;
					case 'e': return Language.OGE;
					case 'g': return Language.OGG;
					case 'o': return Language.OGO;
					case 'u': return Language.OGU;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_oh(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 't': return Language.OHT;
					case 'u': return Language.OHU;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_oi(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.OIA;
					case 'n': return Language.OIN;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ok(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.OKA;
					case 'b': return Language.OKB;
					case 'd': return Language.OKD;
					case 'e': return Language.OKE;
					case 'g': return Language.OKG;
					case 'h': return Language.OKH;
					case 'i': return Language.OKI;
					case 'j': return Language.OKJ;
					case 'k': return Language.OKK;
					case 'l': return Language.OKL;
					case 'm': return Language.OKM;
					case 'n': return Language.OKN;
					case 'o': return Language.OKO;
					case 'r': return Language.OKR;
					case 's': return Language.OKS;
					case 'u': return Language.OKU;
					case 'v': return Language.OKV;
					case 'x': return Language.OKX;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ol(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.OLA;
					case 'd': return Language.OLD;
					case 'e': return Language.OLE;
					case 'k': return Language.OLK;
					case 'm': return Language.OLM;
					case 'o': return Language.OLO;
					case 'r': return Language.OLR;
					case 't': return Language.OLT;
					case 'u': return Language.OLU;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_on(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.ONA;
					case 'b': return Language.ONB;
					case 'e': return Language.ONE;
					case 'g': return Language.ONG;
					case 'i': return Language.ONI;
					case 'j': return Language.ONJ;
					case 'k': return Language.ONK;
					case 'n': return Language.ONN;
					case 'o': return Language.ONO;
					case 'p': return Language.ONP;
					case 'r': return Language.ONR;
					case 's': return Language.ONS;
					case 't': return Language.ONT;
					case 'u': return Language.ONU;
					case 'w': return Language.ONW;
					case 'x': return Language.ONX;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_oo(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'd': return Language.OOD;
					case 'g': return Language.OOG;
					case 'n': return Language.OON;
					case 'r': return Language.OOR;
					case 's': return Language.OOS;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_op(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.OPA;
					case 'k': return Language.OPK;
					case 'm': return Language.OPM;
					case 'o': return Language.OPO;
					case 't': return Language.OPT;
					case 'y': return Language.OPY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ot(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.OTA;
					case 'b': return Language.OTB;
					case 'd': return Language.OTD;
					case 'e': return Language.OTE;
					case 'i': return Language.OTI;
					case 'k': return Language.OTK;
					case 'l': return Language.OTL;
					case 'm': return Language.OTM;
					case 'n': return Language.OTN;
					case 'o': return Language.OTO;
					case 'q': return Language.OTQ;
					case 'r': return Language.OTR;
					case 's': return Language.OTS;
					case 't': return Language.OTT;
					case 'u': return Language.OTU;
					case 'w': return Language.OTW;
					case 'x': return Language.OTX;
					case 'y': return Language.OTY;
					case 'z': return Language.OTZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ou(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.OUA;
					case 'b': return Language.OUB;
					case 'e': return Language.OUE;
					case 'i': return Language.OUI;
					case 'm': return Language.OUM;
					case 'n': return Language.VAJ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ov(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'd': return Language.OVD;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ow(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'i': return Language.OWI;
					case 'l': return Language.OWL;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_oy(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.OYB;
					case 'd': return Language.OYD;
					case 'm': return Language.OYM;
					case 'y': return Language.OYY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_oz(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'm': return Language.OZM;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_p(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return tryParseFromLanguage_pa(text, ref offset);
					case 'i': return tryParseFromLanguage_pi(text, ref offset);
					case 'l': return tryParseFromLanguage_pl(text, ref offset);
					case 's': return tryParseFromLanguage_ps(text, ref offset);
					case 't': return tryParseFromLanguage_pt(text, ref offset);
					case 'b': return tryParseFromLanguage_pb(text, ref offset);
					case 'c': return tryParseFromLanguage_pc(text, ref offset);
					case 'd': return tryParseFromLanguage_pd(text, ref offset);
					case 'e': return tryParseFromLanguage_pe(text, ref offset);
					case 'f': return tryParseFromLanguage_pf(text, ref offset);
					case 'g': return tryParseFromLanguage_pg(text, ref offset);
					case 'h': return tryParseFromLanguage_ph(text, ref offset);
					case 'j': return tryParseFromLanguage_pj(text, ref offset);
					case 'k': return tryParseFromLanguage_pk(text, ref offset);
					case 'm': return tryParseFromLanguage_pm(text, ref offset);
					case 'n': return tryParseFromLanguage_pn(text, ref offset);
					case 'o': return tryParseFromLanguage_po(text, ref offset);
					case 'p': return tryParseFromLanguage_pp(text, ref offset);
					case 'q': return tryParseFromLanguage_pq(text, ref offset);
					case 'r': return tryParseFromLanguage_pr(text, ref offset);
					case 'u': return tryParseFromLanguage_pu(text, ref offset);
					case 'w': return tryParseFromLanguage_pw(text, ref offset);
					case 'x': return tryParseFromLanguage_px(text, ref offset);
					case 'y': return tryParseFromLanguage_py(text, ref offset);
					case 'z': return tryParseFromLanguage_pz(text, ref offset);
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_pa(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.PAA;
					case 'b': return Language.PAB;
					case 'c': return Language.PAC;
					case 'd': return Language.PAD;
					case 'e': return Language.PAE;
					case 'f': return Language.PAF;
					case 'g': return Language.PAG;
					case 'h': return Language.PAH;
					case 'i': return Language.PAI;
					case 'k': return Language.PAK;
					case 'l': return Language.PAL;
					case 'm': return Language.PAM;
					case 'o': return Language.PAO;
					case 'p': return Language.PAP;
					case 'q': return Language.PAQ;
					case 'r': return Language.PAR;
					case 's': return Language.PAS;
					case 't': return Language.PAT;
					case 'u': return Language.PAU;
					case 'v': return Language.PAV;
					case 'w': return Language.PAW;
					case 'x': return Language.PAX;
					case 'y': return Language.PAY;
					case 'z': return Language.PAZ;
				}
				offset--;
			}
			return Language.PA;
		}

		private static Language? tryParseFromLanguage_pi(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.PIA;
					case 'b': return Language.PIB;
					case 'c': return Language.PIC;
					case 'd': return Language.PID;
					case 'e': return Language.PIE;
					case 'f': return Language.PIF;
					case 'g': return Language.PIG;
					case 'h': return Language.PIH;
					case 'i': return Language.PII;
					case 'j': return Language.PIJ;
					case 'l': return Language.PIL;
					case 'm': return Language.PIM;
					case 'n': return Language.PIN;
					case 'o': return Language.PIO;
					case 'p': return Language.PIP;
					case 'r': return Language.PIR;
					case 's': return Language.PIS;
					case 't': return Language.PIT;
					case 'u': return Language.PIU;
					case 'v': return Language.PIV;
					case 'w': return Language.PIW;
					case 'x': return Language.PIX;
					case 'y': return Language.PIY;
					case 'z': return Language.PIZ;
				}
				offset--;
			}
			return Language.PI;
		}

		private static Language? tryParseFromLanguage_pl(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.PLA;
					case 'b': return Language.PLB;
					case 'c': return Language.PLC;
					case 'd': return Language.PLD;
					case 'e': return Language.PLE;
					case 'f': return Language.PLF;
					case 'g': return Language.PLG;
					case 'h': return Language.PLH;
					case 'j': return Language.PLJ;
					case 'k': return Language.PLK;
					case 'l': return Language.PLL;
					case 'n': return Language.PLN;
					case 'o': return Language.PLO;
					case 'p': return Language.PLP;
					case 'q': return Language.PLQ;
					case 'r': return Language.PLR;
					case 's': return Language.PLS;
					case 't': return Language.PLT;
					case 'u': return Language.PLU;
					case 'v': return Language.PLV;
					case 'w': return Language.PLW;
					case 'y': return Language.PLY;
					case 'z': return Language.PLZ;
				}
				offset--;
			}
			return Language.PL;
		}

		private static Language? tryParseFromLanguage_ps(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.PSA;
					case 'c': return Language.PSC;
					case 'd': return Language.PSD;
					case 'e': return Language.PSE;
					case 'g': return Language.PSG;
					case 'h': return Language.PSH;
					case 'i': return Language.PSI;
					case 'l': return Language.PSL;
					case 'm': return Language.PSM;
					case 'n': return Language.PSN;
					case 'o': return Language.PSO;
					case 'p': return Language.PSP;
					case 'q': return Language.PSQ;
					case 'r': return Language.PSR;
					case 's': return Language.PSS;
					case 't': return Language.PST;
					case 'u': return Language.PSU;
					case 'w': return Language.PSW;
					case 'y': return Language.PSY;
				}
				offset--;
			}
			return Language.PS;
		}

		private static Language? tryParseFromLanguage_pt(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.PTA;
					case 'h': return Language.PTH;
					case 'i': return Language.PTI;
					case 'n': return Language.PTN;
					case 'o': return Language.PTO;
					case 'p': return Language.PTP;
					case 'q': return Language.PTQ;
					case 'r': return Language.PTR;
					case 't': return Language.PTT;
					case 'u': return Language.PTU;
					case 'v': return Language.PTV;
					case 'w': return Language.PTW;
					case 'y': return Language.PTY;
				}
				offset--;
			}
			return Language.PT;
		}

		private static Language? tryParseFromLanguage_pb(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.PBB;
					case 'c': return Language.PBC;
					case 'e': return Language.PBE;
					case 'f': return Language.PBF;
					case 'g': return Language.PBG;
					case 'h': return Language.PBH;
					case 'i': return Language.PBI;
					case 'l': return Language.PBL;
					case 'n': return Language.PBN;
					case 'o': return Language.PBO;
					case 'p': return Language.PBP;
					case 'r': return Language.PBR;
					case 's': return Language.PBS;
					case 't': return Language.PBT;
					case 'u': return Language.PBU;
					case 'v': return Language.PBV;
					case 'y': return Language.PBY;
					case 'z': return Language.PBZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_pc(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.PCA;
					case 'b': return Language.PCB;
					case 'c': return Language.PCC;
					case 'd': return Language.PCD;
					case 'e': return Language.PCE;
					case 'f': return Language.PCF;
					case 'g': return Language.PCG;
					case 'h': return Language.PCH;
					case 'i': return Language.PCI;
					case 'j': return Language.PCJ;
					case 'k': return Language.PCK;
					case 'l': return Language.PCL;
					case 'm': return Language.PCM;
					case 'n': return Language.PCN;
					case 'p': return Language.PCP;
					case 'r': return Language.ADX;
					case 'w': return Language.PCW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_pd(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.PDA;
					case 'c': return Language.PDC;
					case 'i': return Language.PDI;
					case 'n': return Language.PDN;
					case 'o': return Language.PDO;
					case 't': return Language.PDT;
					case 'u': return Language.PDU;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_pe(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.PEA;
					case 'b': return Language.PEB;
					case 'd': return Language.PED;
					case 'e': return Language.PEE;
					case 'f': return Language.PEF;
					case 'g': return Language.PEG;
					case 'h': return Language.PEH;
					case 'i': return Language.PEI;
					case 'j': return Language.PEJ;
					case 'k': return Language.PEK;
					case 'l': return Language.PEL;
					case 'm': return Language.PEM;
					case 'o': return Language.PEO;
					case 'p': return Language.PEP;
					case 'q': return Language.PEQ;
					case 's': return Language.PES;
					case 'v': return Language.PEV;
					case 'x': return Language.PEX;
					case 'y': return Language.PEY;
					case 'z': return Language.PEZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_pf(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.PFA;
					case 'e': return Language.PFE;
					case 'l': return Language.PFL;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_pg(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.PGA;
					case 'd': return Language.PGD;
					case 'g': return Language.PGG;
					case 'i': return Language.PGI;
					case 'k': return Language.PGK;
					case 'l': return Language.PGL;
					case 'n': return Language.PGN;
					case 's': return Language.PGS;
					case 'u': return Language.PGU;
					case 'y': return Language.PGY;
					case 'z': return Language.PGZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ph(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.PHA;
					case 'd': return Language.PHD;
					case 'g': return Language.PHG;
					case 'h': return Language.PHH;
					case 'i': return Language.PHI;
					case 'k': return Language.PHK;
					case 'l': return Language.PHL;
					case 'm': return Language.PHM;
					case 'n': return Language.PHN;
					case 'o': return Language.PHO;
					case 'q': return Language.PHQ;
					case 'r': return Language.PHR;
					case 't': return Language.PHT;
					case 'u': return Language.PHU;
					case 'v': return Language.PHV;
					case 'w': return Language.PHW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_pj(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 't': return Language.PJT;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_pk(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.PKA;
					case 'b': return Language.PKB;
					case 'c': return Language.PKC;
					case 'g': return Language.PKG;
					case 'h': return Language.PKH;
					case 'n': return Language.PKN;
					case 'o': return Language.PKO;
					case 'p': return Language.PKP;
					case 'r': return Language.PKR;
					case 's': return Language.PKS;
					case 't': return Language.PKT;
					case 'u': return Language.PKU;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_pm(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.PMA;
					case 'b': return Language.PMB;
					case 'c': return Language.HUW;
					case 'd': return Language.PMD;
					case 'e': return Language.PME;
					case 'f': return Language.PMF;
					case 'h': return Language.PMH;
					case 'i': return Language.PMI;
					case 'j': return Language.PMJ;
					case 'k': return Language.PMK;
					case 'l': return Language.PML;
					case 'm': return Language.PMM;
					case 'n': return Language.PMN;
					case 'o': return Language.PMO;
					case 'q': return Language.PMQ;
					case 'r': return Language.PMR;
					case 's': return Language.PMS;
					case 't': return Language.PMT;
					case 'u': return Language.PHR;
					case 'w': return Language.PMW;
					case 'x': return Language.PMX;
					case 'y': return Language.PMY;
					case 'z': return Language.PMZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_pn(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.PNA;
					case 'b': return Language.PNB;
					case 'c': return Language.PNC;
					case 'e': return Language.PNE;
					case 'g': return Language.PNG;
					case 'h': return Language.PNH;
					case 'i': return Language.PNI;
					case 'j': return Language.PNJ;
					case 'k': return Language.PNK;
					case 'l': return Language.PNL;
					case 'm': return Language.PNM;
					case 'n': return Language.PNN;
					case 'o': return Language.PNO;
					case 'p': return Language.PNP;
					case 'q': return Language.PNQ;
					case 'r': return Language.PNR;
					case 's': return Language.PNS;
					case 't': return Language.PNT;
					case 'u': return Language.PNU;
					case 'v': return Language.PNV;
					case 'w': return Language.PNW;
					case 'x': return Language.PNX;
					case 'y': return Language.PNY;
					case 'z': return Language.PNZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_po(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'c': return Language.POC;
					case 'd': return Language.POD;
					case 'e': return Language.POE;
					case 'f': return Language.POF;
					case 'g': return Language.POG;
					case 'h': return Language.POH;
					case 'i': return Language.POI;
					case 'k': return Language.POK;
					case 'm': return Language.POM;
					case 'n': return Language.PON;
					case 'o': return Language.POO;
					case 'p': return Language.POP;
					case 'q': return Language.POQ;
					case 's': return Language.POS;
					case 't': return Language.POT;
					case 'v': return Language.POV;
					case 'w': return Language.POW;
					case 'x': return Language.POX;
					case 'y': return Language.POY;
					case 'z': return Language.POZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_pp(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.BFY;
					case 'e': return Language.PPE;
					case 'i': return Language.PPI;
					case 'k': return Language.PPK;
					case 'l': return Language.PPL;
					case 'm': return Language.PPM;
					case 'n': return Language.PPN;
					case 'o': return Language.PPO;
					case 'p': return Language.PPP;
					case 'q': return Language.PPQ;
					case 'r': return Language.LCQ;
					case 's': return Language.PPS;
					case 't': return Language.PPT;
					case 'u': return Language.PPU;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_pq(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.PQA;
					case 'e': return Language.PQE;
					case 'm': return Language.PQM;
					case 'w': return Language.PQW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_pr(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.PRA;
					case 'b': return Language.PRB;
					case 'c': return Language.PRC;
					case 'd': return Language.PRD;
					case 'e': return Language.PRE;
					case 'f': return Language.PRF;
					case 'g': return Language.PRG;
					case 'h': return Language.PRH;
					case 'i': return Language.PRI;
					case 'k': return Language.PRK;
					case 'l': return Language.PRL;
					case 'm': return Language.PRM;
					case 'n': return Language.PRN;
					case 'o': return Language.PRO;
					case 'p': return Language.PRP;
					case 'q': return Language.PRQ;
					case 'r': return Language.PRR;
					case 's': return Language.PRS;
					case 't': return Language.PRT;
					case 'u': return Language.PRU;
					case 'w': return Language.PRW;
					case 'x': return Language.PRX;
					case 'y': return Language.PRT;
					case 'z': return Language.PRZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_pu(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.PUA;
					case 'b': return Language.PUB;
					case 'c': return Language.PUC;
					case 'd': return Language.PUD;
					case 'e': return Language.PUE;
					case 'f': return Language.PUF;
					case 'g': return Language.PUG;
					case 'i': return Language.PUI;
					case 'j': return Language.PUJ;
					case 'k': return Language.PUK;
					case 'm': return Language.PUM;
					case 'o': return Language.PUO;
					case 'p': return Language.PUP;
					case 'q': return Language.PUQ;
					case 'r': return Language.PUR;
					case 't': return Language.PUT;
					case 'u': return Language.PUU;
					case 'w': return Language.PUW;
					case 'x': return Language.PUX;
					case 'y': return Language.PUY;
					case 'z': return Language.PUB;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_pw(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.PWA;
					case 'b': return Language.PWB;
					case 'g': return Language.PWG;
					case 'i': return Language.PWI;
					case 'm': return Language.PWM;
					case 'n': return Language.PWN;
					case 'o': return Language.PWO;
					case 'r': return Language.PWR;
					case 'w': return Language.PWW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_px(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'm': return Language.PXM;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_py(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'e': return Language.PYE;
					case 'm': return Language.PYM;
					case 'n': return Language.PYN;
					case 's': return Language.PYS;
					case 'u': return Language.PYU;
					case 'x': return Language.PYX;
					case 'y': return Language.PYY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_pz(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'n': return Language.PZN;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_q(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'u': return tryParseFromLanguage_qu(text, ref offset);
					case 'v': return tryParseFromLanguage_qv(text, ref offset);
					case 'w': return tryParseFromLanguage_qw(text, ref offset);
					case 'x': return tryParseFromLanguage_qx(text, ref offset);
					case 'y': return tryParseFromLanguage_qy(text, ref offset);
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_qu(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.QUA;
					case 'b': return Language.QUB;
					case 'c': return Language.QUC;
					case 'd': return Language.QUD;
					case 'f': return Language.QUF;
					case 'g': return Language.QUG;
					case 'h': return Language.QUH;
					case 'i': return Language.QUI;
					case 'k': return Language.QUK;
					case 'l': return Language.QUL;
					case 'm': return Language.QUM;
					case 'n': return Language.QUN;
					case 'p': return Language.QUP;
					case 'q': return Language.QUQ;
					case 'r': return Language.QUR;
					case 's': return Language.QUS;
					case 'v': return Language.QUV;
					case 'w': return Language.QUW;
					case 'x': return Language.QUX;
					case 'y': return Language.QUY;
					case 'z': return Language.QUZ;
				}
				offset--;
			}
			return Language.QU;
		}

		private static Language? tryParseFromLanguage_qv(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.QVA;
					case 'c': return Language.QVC;
					case 'e': return Language.QVE;
					case 'h': return Language.QVH;
					case 'i': return Language.QVI;
					case 'j': return Language.QVJ;
					case 'l': return Language.QVL;
					case 'm': return Language.QVM;
					case 'n': return Language.QVN;
					case 'o': return Language.QVO;
					case 'p': return Language.QVP;
					case 's': return Language.QVS;
					case 'w': return Language.QVW;
					case 'y': return Language.QVY;
					case 'z': return Language.QVZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_qw(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.QWA;
					case 'c': return Language.QWC;
					case 'e': return Language.QWE;
					case 'h': return Language.QWH;
					case 'm': return Language.QWM;
					case 's': return Language.QWS;
					case 't': return Language.QWT;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_qx(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.QXA;
					case 'c': return Language.QXC;
					case 'h': return Language.QXH;
					case 'l': return Language.QXL;
					case 'n': return Language.QXN;
					case 'o': return Language.QXO;
					case 'p': return Language.QXP;
					case 'q': return Language.QXQ;
					case 'r': return Language.QXR;
					case 's': return Language.QXS;
					case 't': return Language.QXT;
					case 'u': return Language.QXU;
					case 'w': return Language.QXW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_qy(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.QYA;
					case 'p': return Language.QYP;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_r(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'm': return tryParseFromLanguage_rm(text, ref offset);
					case 'n': return tryParseFromLanguage_rn(text, ref offset);
					case 'o': return tryParseFromLanguage_ro(text, ref offset);
					case 'u': return tryParseFromLanguage_ru(text, ref offset);
					case 'w': return tryParseFromLanguage_rw(text, ref offset);
					case 'a': return tryParseFromLanguage_ra(text, ref offset);
					case 'b': return tryParseFromLanguage_rb(text, ref offset);
					case 'c': return tryParseFromLanguage_rc(text, ref offset);
					case 'd': return tryParseFromLanguage_rd(text, ref offset);
					case 'e': return tryParseFromLanguage_re(text, ref offset);
					case 'g': return tryParseFromLanguage_rg(text, ref offset);
					case 'h': return tryParseFromLanguage_rh(text, ref offset);
					case 'i': return tryParseFromLanguage_ri(text, ref offset);
					case 'j': return tryParseFromLanguage_rj(text, ref offset);
					case 'k': return tryParseFromLanguage_rk(text, ref offset);
					case 'p': return tryParseFromLanguage_rp(text, ref offset);
					case 'r': return tryParseFromLanguage_rr(text, ref offset);
					case 's': return tryParseFromLanguage_rs(text, ref offset);
					case 't': return tryParseFromLanguage_rt(text, ref offset);
					case 'x': return tryParseFromLanguage_rx(text, ref offset);
					case 'y': return tryParseFromLanguage_ry(text, ref offset);
					case 'z': return tryParseFromLanguage_rz(text, ref offset);
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_rm(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.RMA;
					case 'b': return Language.RMB;
					case 'c': return Language.RMC;
					case 'd': return Language.RMD;
					case 'e': return Language.RME;
					case 'f': return Language.RMF;
					case 'g': return Language.RMG;
					case 'h': return Language.RMH;
					case 'i': return Language.RMI;
					case 'k': return Language.RMK;
					case 'l': return Language.RML;
					case 'm': return Language.RMM;
					case 'n': return Language.RMN;
					case 'o': return Language.RMO;
					case 'p': return Language.RMP;
					case 'q': return Language.RMQ;
					case 'r': return Language.RMR;
					case 's': return Language.RMS;
					case 't': return Language.RMT;
					case 'u': return Language.RMU;
					case 'v': return Language.RMV;
					case 'w': return Language.RMW;
					case 'x': return Language.RMX;
					case 'y': return Language.RMY;
					case 'z': return Language.RMZ;
				}
				offset--;
			}
			return Language.RM;
		}

		private static Language? tryParseFromLanguage_rn(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.RNA;
					case 'd': return Language.RND;
					case 'g': return Language.RNG;
					case 'l': return Language.RNL;
					case 'n': return Language.RNN;
					case 'p': return Language.RNP;
					case 'r': return Language.RNR;
					case 'w': return Language.RNW;
				}
				offset--;
			}
			return Language.RN;
		}

		private static Language? tryParseFromLanguage_ro(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.ROA;
					case 'b': return Language.ROB;
					case 'c': return Language.ROC;
					case 'd': return Language.ROD;
					case 'e': return Language.ROE;
					case 'f': return Language.ROF;
					case 'g': return Language.ROG;
					case 'l': return Language.ROL;
					case 'm': return Language.ROM;
					case 'o': return Language.ROO;
					case 'p': return Language.ROP;
					case 'r': return Language.ROR;
					case 'u': return Language.ROU;
					case 'w': return Language.ROW;
				}
				offset--;
			}
			return Language.RO;
		}

		private static Language? tryParseFromLanguage_ru(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.RUB;
					case 'c': return Language.RUC;
					case 'e': return Language.RUE;
					case 'f': return Language.RUF;
					case 'g': return Language.RUG;
					case 'h': return Language.RUH;
					case 'i': return Language.RUI;
					case 'k': return Language.RUK;
					case 'o': return Language.RUO;
					case 'p': return Language.RUP;
					case 'q': return Language.RUQ;
					case 't': return Language.RUT;
					case 'u': return Language.RUU;
					case 'y': return Language.RUY;
					case 'z': return Language.RUZ;
				}
				offset--;
			}
			return Language.RU;
		}

		private static Language? tryParseFromLanguage_rw(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.RWA;
					case 'k': return Language.RWK;
					case 'm': return Language.RWM;
					case 'o': return Language.RWO;
					case 'r': return Language.RWR;
				}
				offset--;
			}
			return Language.RW;
		}

		private static Language? tryParseFromLanguage_ra(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.RAA;
					case 'b': return Language.RAB;
					case 'c': return Language.RAC;
					case 'd': return Language.RAD;
					case 'f': return Language.RAF;
					case 'g': return Language.RAG;
					case 'h': return Language.RAH;
					case 'i': return Language.RAI;
					case 'j': return Language.RAJ;
					case 'k': return Language.RAK;
					case 'l': return Language.RAL;
					case 'm': return Language.RAM;
					case 'n': return Language.RAN;
					case 'o': return Language.RAO;
					case 'p': return Language.RAP;
					case 'q': return Language.RAQ;
					case 'r': return Language.RAR;
					case 's': return Language.RAS;
					case 't': return Language.RAT;
					case 'u': return Language.RAU;
					case 'v': return Language.RAV;
					case 'w': return Language.RAW;
					case 'x': return Language.RAX;
					case 'y': return Language.RAY;
					case 'z': return Language.RAZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_rb(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.RBB;
					case 'k': return Language.RBK;
					case 'l': return Language.RBL;
					case 'p': return Language.RBP;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_rc(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'f': return Language.RCF;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_rd(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.RDB;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_re(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.REA;
					case 'b': return Language.REB;
					case 'e': return Language.REE;
					case 'g': return Language.REG;
					case 'i': return Language.REI;
					case 'j': return Language.REJ;
					case 'l': return Language.REL;
					case 'm': return Language.REM;
					case 'n': return Language.REN;
					case 'r': return Language.RER;
					case 's': return Language.RES;
					case 't': return Language.RET;
					case 'y': return Language.REY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_rg(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.RGA;
					case 'e': return Language.RGE;
					case 'k': return Language.RGK;
					case 'n': return Language.RGN;
					case 'r': return Language.RGR;
					case 's': return Language.RGS;
					case 'u': return Language.RGU;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_rh(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'g': return Language.RHG;
					case 'p': return Language.RHP;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ri(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.RIA;
					case 'e': return Language.RIE;
					case 'f': return Language.RIF;
					case 'l': return Language.RIL;
					case 'm': return Language.RIM;
					case 'n': return Language.RIN;
					case 'r': return Language.RIR;
					case 't': return Language.RIT;
					case 'u': return Language.RIU;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_rj(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'g': return Language.RJG;
					case 'i': return Language.RJI;
					case 's': return Language.RJS;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_rk(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.RKA;
					case 'b': return Language.RKB;
					case 'h': return Language.RKH;
					case 'i': return Language.RKI;
					case 'm': return Language.RKM;
					case 't': return Language.RKT;
					case 'w': return Language.RKW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_rp(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'n': return Language.RPN;
					case 't': return Language.RPT;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_rr(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'i': return Language.RRI;
					case 'o': return Language.RRO;
					case 't': return Language.RRT;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_rs(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.RSB;
					case 'i': return Language.RSI;
					case 'l': return Language.RSL;
					case 'm': return Language.RSM;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_rt(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'c': return Language.RTC;
					case 'h': return Language.RTH;
					case 'm': return Language.RTM;
					case 's': return Language.RTS;
					case 'w': return Language.RTW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_rx(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'd': return Language.RXD;
					case 'w': return Language.RXW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ry(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'n': return Language.RYN;
					case 's': return Language.RYS;
					case 'u': return Language.RYU;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_rz(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'h': return Language.RZH;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_s(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return tryParseFromLanguage_sa(text, ref offset);
					case 'c': return tryParseFromLanguage_sc(text, ref offset);
					case 'd': return tryParseFromLanguage_sd(text, ref offset);
					case 'e': return tryParseFromLanguage_se(text, ref offset);
					case 'g': return tryParseFromLanguage_sg(text, ref offset);
					case 'h': return tryParseFromLanguage_sh(text, ref offset);
					case 'i': return tryParseFromLanguage_si(text, ref offset);
					case 'k': return tryParseFromLanguage_sk(text, ref offset);
					case 'l': return tryParseFromLanguage_sl(text, ref offset);
					case 'm': return tryParseFromLanguage_sm(text, ref offset);
					case 'n': return tryParseFromLanguage_sn(text, ref offset);
					case 'o': return tryParseFromLanguage_so(text, ref offset);
					case 'q': return tryParseFromLanguage_sq(text, ref offset);
					case 'r': return tryParseFromLanguage_sr(text, ref offset);
					case 's': return tryParseFromLanguage_ss(text, ref offset);
					case 't': return tryParseFromLanguage_st(text, ref offset);
					case 'u': return tryParseFromLanguage_su(text, ref offset);
					case 'v': return tryParseFromLanguage_sv(text, ref offset);
					case 'w': return tryParseFromLanguage_sw(text, ref offset);
					case 'b': return tryParseFromLanguage_sb(text, ref offset);
					case 'f': return tryParseFromLanguage_sf(text, ref offset);
					case 'j': return tryParseFromLanguage_sj(text, ref offset);
					case 'p': return tryParseFromLanguage_sp(text, ref offset);
					case 'x': return tryParseFromLanguage_sx(text, ref offset);
					case 'y': return tryParseFromLanguage_sy(text, ref offset);
					case 'z': return tryParseFromLanguage_sz(text, ref offset);
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_sa(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.SAA;
					case 'b': return Language.SAB;
					case 'c': return Language.SAC;
					case 'd': return Language.SAD;
					case 'e': return Language.SAE;
					case 'f': return Language.SAF;
					case 'h': return Language.SAH;
					case 'i': return Language.SAI;
					case 'j': return Language.SAJ;
					case 'k': return Language.SAK;
					case 'l': return Language.SAL;
					case 'm': return Language.SAM;
					case 'o': return Language.SAO;
					case 'p': return Language.SAP;
					case 'q': return Language.SAQ;
					case 'r': return Language.SAR;
					case 's': return Language.SAS;
					case 't': return Language.SAT;
					case 'u': return Language.SAU;
					case 'v': return Language.SAV;
					case 'w': return Language.SAW;
					case 'x': return Language.SAX;
					case 'y': return Language.SAY;
					case 'z': return Language.SAZ;
				}
				offset--;
			}
			return Language.SA;
		}

		private static Language? tryParseFromLanguage_sc(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.HLE;
					case 'b': return Language.SCB;
					case 'e': return Language.SCE;
					case 'f': return Language.SCF;
					case 'g': return Language.SCG;
					case 'h': return Language.SCH;
					case 'i': return Language.SCI;
					case 'k': return Language.SCK;
					case 'l': return Language.SCL;
					case 'n': return Language.SCN;
					case 'o': return Language.SCO;
					case 'p': return Language.SCP;
					case 'q': return Language.SCQ;
					case 's': return Language.SCS;
					case 'u': return Language.SCU;
					case 'v': return Language.SCV;
					case 'w': return Language.SCW;
					case 'x': return Language.SCX;
				}
				offset--;
			}
			return Language.SC;
		}

		private static Language? tryParseFromLanguage_sd(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.SDA;
					case 'b': return Language.SDB;
					case 'c': return Language.SDC;
					case 'e': return Language.SDE;
					case 'f': return Language.SDF;
					case 'g': return Language.SDG;
					case 'h': return Language.SDH;
					case 'j': return Language.SDJ;
					case 'k': return Language.SDK;
					case 'l': return Language.SDL;
					case 'm': return Language.SDM;
					case 'n': return Language.SDN;
					case 'o': return Language.SDO;
					case 'p': return Language.SDP;
					case 'r': return Language.SDR;
					case 's': return Language.SDS;
					case 't': return Language.SDT;
					case 'u': return Language.SDU;
					case 'v': return Language.SDV;
					case 'x': return Language.SDX;
					case 'z': return Language.SDZ;
				}
				offset--;
			}
			return Language.SD;
		}

		private static Language? tryParseFromLanguage_se(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.SEA;
					case 'b': return Language.SEB;
					case 'c': return Language.SEC;
					case 'd': return Language.SED;
					case 'e': return Language.SEE;
					case 'f': return Language.SEF;
					case 'g': return Language.SEG;
					case 'h': return Language.SEH;
					case 'i': return Language.SEI;
					case 'j': return Language.SEJ;
					case 'k': return Language.SEK;
					case 'l': return Language.SEL;
					case 'm': return Language.SEM;
					case 'n': return Language.SEN;
					case 'o': return Language.SEO;
					case 'p': return Language.SEP;
					case 'q': return Language.SEQ;
					case 'r': return Language.SER;
					case 's': return Language.SES;
					case 't': return Language.SET;
					case 'u': return Language.SEU;
					case 'v': return Language.SEV;
					case 'w': return Language.SEW;
					case 'y': return Language.SEY;
					case 'z': return Language.SEZ;
				}
				offset--;
			}
			return Language.SE;
		}

		private static Language? tryParseFromLanguage_sg(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.SGA;
					case 'b': return Language.SGB;
					case 'c': return Language.SGC;
					case 'd': return Language.SGD;
					case 'e': return Language.SGE;
					case 'g': return Language.SGG;
					case 'h': return Language.SGH;
					case 'i': return Language.SGI;
					case 'j': return Language.SGJ;
					case 'k': return Language.SGK;
					case 'l': return Language.SGL;
					case 'm': return Language.SGM;
					case 'n': return Language.SGN;
					case 'o': return Language.SGO;
					case 'p': return Language.SGP;
					case 'r': return Language.SGR;
					case 's': return Language.SGS;
					case 't': return Language.SGT;
					case 'u': return Language.SGU;
					case 'w': return Language.SGW;
					case 'x': return Language.SGX;
					case 'y': return Language.SGY;
					case 'z': return Language.SGZ;
				}
				offset--;
			}
			return Language.SG;
		}

		private static Language? tryParseFromLanguage_sh(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.SHA;
					case 'b': return Language.SHB;
					case 'c': return Language.SHC;
					case 'd': return Language.SHD;
					case 'e': return Language.SHE;
					case 'g': return Language.SHG;
					case 'h': return Language.SHH;
					case 'i': return Language.SHI;
					case 'j': return Language.SHJ;
					case 'k': return Language.SHK;
					case 'l': return Language.SHL;
					case 'm': return Language.SHM;
					case 'n': return Language.SHN;
					case 'o': return Language.SHO;
					case 'p': return Language.SHP;
					case 'q': return Language.SHQ;
					case 'r': return Language.SHR;
					case 's': return Language.SHS;
					case 't': return Language.SHT;
					case 'u': return Language.SHU;
					case 'v': return Language.SHV;
					case 'w': return Language.SHW;
					case 'x': return Language.SHX;
					case 'y': return Language.SHY;
					case 'z': return Language.SHZ;
				}
				offset--;
			}
			return Language.SH;
		}

		private static Language? tryParseFromLanguage_si(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.SIA;
					case 'b': return Language.SIB;
					case 'd': return Language.SID;
					case 'e': return Language.SIE;
					case 'f': return Language.SIF;
					case 'g': return Language.SIG;
					case 'h': return Language.SIH;
					case 'i': return Language.SII;
					case 'j': return Language.SIJ;
					case 'k': return Language.SIK;
					case 'l': return Language.SIL;
					case 'm': return Language.SIM;
					case 'o': return Language.SIO;
					case 'p': return Language.SIP;
					case 'q': return Language.SIQ;
					case 'r': return Language.SIR;
					case 's': return Language.SIS;
					case 't': return Language.SIT;
					case 'u': return Language.SIU;
					case 'v': return Language.SIV;
					case 'w': return Language.SIW;
					case 'x': return Language.SIX;
					case 'y': return Language.SIY;
					case 'z': return Language.SIZ;
				}
				offset--;
			}
			return Language.SI;
		}

		private static Language? tryParseFromLanguage_sk(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.SKA;
					case 'b': return Language.SKB;
					case 'c': return Language.SKC;
					case 'd': return Language.SKD;
					case 'e': return Language.SKE;
					case 'f': return Language.SKF;
					case 'g': return Language.SKG;
					case 'h': return Language.SKH;
					case 'i': return Language.SKI;
					case 'j': return Language.SKJ;
					case 'k': return Language.SKK;
					case 'm': return Language.SKM;
					case 'n': return Language.SKN;
					case 'o': return Language.SKO;
					case 'p': return Language.SKP;
					case 'q': return Language.SKQ;
					case 'r': return Language.SKR;
					case 's': return Language.SKS;
					case 't': return Language.SKT;
					case 'u': return Language.SKU;
					case 'v': return Language.SKV;
					case 'w': return Language.SKW;
					case 'x': return Language.SKX;
					case 'y': return Language.SKY;
					case 'z': return Language.SKZ;
				}
				offset--;
			}
			return Language.SK;
		}

		private static Language? tryParseFromLanguage_sl(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.SLA;
					case 'c': return Language.SLC;
					case 'd': return Language.SLD;
					case 'e': return Language.SLE;
					case 'f': return Language.SLF;
					case 'g': return Language.SLG;
					case 'h': return Language.SLH;
					case 'i': return Language.SLI;
					case 'j': return Language.SLJ;
					case 'l': return Language.SLL;
					case 'm': return Language.SLM;
					case 'n': return Language.SLN;
					case 'p': return Language.SLP;
					case 'q': return Language.SLQ;
					case 'r': return Language.SLR;
					case 's': return Language.SLS;
					case 't': return Language.SLT;
					case 'u': return Language.SLU;
					case 'w': return Language.SLW;
					case 'x': return Language.SLX;
					case 'y': return Language.SLY;
					case 'z': return Language.SLZ;
				}
				offset--;
			}
			return Language.SL;
		}

		private static Language? tryParseFromLanguage_sm(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.SMA;
					case 'b': return Language.SMB;
					case 'c': return Language.SMC;
					case 'd': return Language.SMD;
					case 'f': return Language.SMF;
					case 'g': return Language.SMG;
					case 'h': return Language.SMH;
					case 'i': return Language.SMI;
					case 'j': return Language.SMJ;
					case 'k': return Language.SMK;
					case 'l': return Language.SML;
					case 'm': return Language.SMM;
					case 'n': return Language.SMN;
					case 'p': return Language.SMP;
					case 'q': return Language.SMQ;
					case 'r': return Language.SMR;
					case 's': return Language.SMS;
					case 't': return Language.SMT;
					case 'u': return Language.SMU;
					case 'v': return Language.SMV;
					case 'w': return Language.SMW;
					case 'x': return Language.SMX;
					case 'y': return Language.SMY;
					case 'z': return Language.SMZ;
				}
				offset--;
			}
			return Language.SM;
		}

		private static Language? tryParseFromLanguage_sn(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.SNB;
					case 'c': return Language.SNC;
					case 'e': return Language.SNE;
					case 'f': return Language.SNF;
					case 'g': return Language.SNG;
					case 'h': return Language.SNH;
					case 'i': return Language.SNI;
					case 'j': return Language.SNJ;
					case 'k': return Language.SNK;
					case 'l': return Language.SNL;
					case 'm': return Language.SNM;
					case 'n': return Language.SNN;
					case 'o': return Language.SNO;
					case 'p': return Language.SNP;
					case 'q': return Language.SNQ;
					case 'r': return Language.SNR;
					case 's': return Language.SNS;
					case 'u': return Language.SNU;
					case 'v': return Language.SNV;
					case 'w': return Language.SNW;
					case 'x': return Language.SNX;
					case 'y': return Language.SNY;
					case 'z': return Language.SNZ;
				}
				offset--;
			}
			return Language.SN;
		}

		private static Language? tryParseFromLanguage_so(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.SOA;
					case 'b': return Language.SOB;
					case 'c': return Language.SOC;
					case 'd': return Language.SOD;
					case 'e': return Language.SOE;
					case 'g': return Language.SOG;
					case 'h': return Language.SOH;
					case 'i': return Language.SOI;
					case 'j': return Language.SOJ;
					case 'k': return Language.SOK;
					case 'l': return Language.SOL;
					case 'n': return Language.SON;
					case 'o': return Language.SOO;
					case 'p': return Language.SOP;
					case 'q': return Language.SOQ;
					case 'r': return Language.SOR;
					case 's': return Language.SOS;
					case 'u': return Language.SOU;
					case 'v': return Language.SOV;
					case 'w': return Language.SOW;
					case 'x': return Language.SOX;
					case 'y': return Language.SOY;
					case 'z': return Language.SOZ;
				}
				offset--;
			}
			return Language.SO;
		}

		private static Language? tryParseFromLanguage_sq(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.SQA;
					case 'h': return Language.SQH;
					case 'j': return Language.SQJ;
					case 'k': return Language.SQK;
					case 'm': return Language.SQM;
					case 'n': return Language.SQN;
					case 'o': return Language.SQO;
					case 'q': return Language.SQQ;
					case 'r': return Language.SQR;
					case 's': return Language.SQS;
					case 't': return Language.SQT;
					case 'u': return Language.SQU;
				}
				offset--;
			}
			return Language.SQ;
		}

		private static Language? tryParseFromLanguage_sr(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.SRA;
					case 'b': return Language.SRB;
					case 'c': return Language.SRC;
					case 'e': return Language.SRE;
					case 'f': return Language.SRF;
					case 'g': return Language.SRG;
					case 'h': return Language.SRH;
					case 'i': return Language.SRI;
					case 'k': return Language.SRK;
					case 'l': return Language.SRL;
					case 'm': return Language.SRM;
					case 'n': return Language.SRN;
					case 'o': return Language.SRO;
					case 'q': return Language.SRQ;
					case 'r': return Language.SRR;
					case 's': return Language.SRS;
					case 't': return Language.SRT;
					case 'u': return Language.SRU;
					case 'v': return Language.SRV;
					case 'w': return Language.SRW;
					case 'x': return Language.SRX;
					case 'y': return Language.SRY;
					case 'z': return Language.SRZ;
				}
				offset--;
			}
			return Language.SR;
		}

		private static Language? tryParseFromLanguage_ss(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.SSA;
					case 'b': return Language.SSB;
					case 'c': return Language.SSC;
					case 'd': return Language.SSD;
					case 'e': return Language.SSE;
					case 'f': return Language.SSF;
					case 'g': return Language.SSG;
					case 'h': return Language.SSH;
					case 'i': return Language.SSI;
					case 'j': return Language.SSJ;
					case 'k': return Language.SSK;
					case 'l': return Language.SSL;
					case 'm': return Language.SSM;
					case 'n': return Language.SSN;
					case 'o': return Language.SSO;
					case 'p': return Language.SSP;
					case 'q': return Language.SSQ;
					case 'r': return Language.SSR;
					case 's': return Language.SSS;
					case 't': return Language.SST;
					case 'u': return Language.SSU;
					case 'v': return Language.SSV;
					case 'x': return Language.SSX;
					case 'y': return Language.SSY;
					case 'z': return Language.SSZ;
				}
				offset--;
			}
			return Language.SS;
		}

		private static Language? tryParseFromLanguage_st(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.STA;
					case 'b': return Language.STB;
					case 'd': return Language.STD;
					case 'e': return Language.STE;
					case 'f': return Language.STF;
					case 'g': return Language.STG;
					case 'h': return Language.STH;
					case 'i': return Language.STI;
					case 'j': return Language.STJ;
					case 'k': return Language.STK;
					case 'l': return Language.STL;
					case 'm': return Language.STM;
					case 'n': return Language.STN;
					case 'o': return Language.STO;
					case 'p': return Language.STP;
					case 'q': return Language.STQ;
					case 'r': return Language.STR;
					case 's': return Language.STS;
					case 't': return Language.STT;
					case 'u': return Language.STU;
					case 'v': return Language.STV;
					case 'w': return Language.STW;
					case 'y': return Language.STY;
				}
				offset--;
			}
			return Language.ST;
		}

		private static Language? tryParseFromLanguage_su(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.SUA;
					case 'b': return Language.SUB;
					case 'c': return Language.SUC;
					case 'e': return Language.SUE;
					case 'g': return Language.SUG;
					case 'i': return Language.SUI;
					case 'j': return Language.SUJ;
					case 'k': return Language.SUK;
					case 'l': return Language.SUL;
					case 'm': return Language.SUM;
					case 'q': return Language.SUQ;
					case 'r': return Language.SUR;
					case 's': return Language.SUS;
					case 't': return Language.SUT;
					case 'v': return Language.SUV;
					case 'w': return Language.SUW;
					case 'x': return Language.SUX;
					case 'y': return Language.SUY;
					case 'z': return Language.SUZ;
				}
				offset--;
			}
			return Language.SU;
		}

		private static Language? tryParseFromLanguage_sv(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.SVA;
					case 'b': return Language.SVB;
					case 'c': return Language.SVC;
					case 'e': return Language.SVE;
					case 'k': return Language.SVK;
					case 'm': return Language.SVM;
					case 'r': return Language.SVR;
					case 's': return Language.SVS;
					case 'x': return Language.SVX;
				}
				offset--;
			}
			return Language.SV;
		}

		private static Language? tryParseFromLanguage_sw(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.SWB;
					case 'c': return Language.SWC;
					case 'f': return Language.SWF;
					case 'g': return Language.SWG;
					case 'h': return Language.SWH;
					case 'i': return Language.SWI;
					case 'j': return Language.SWJ;
					case 'k': return Language.SWK;
					case 'l': return Language.SWL;
					case 'm': return Language.SWM;
					case 'n': return Language.SWN;
					case 'o': return Language.SWO;
					case 'p': return Language.SWP;
					case 'q': return Language.SWQ;
					case 'r': return Language.SWR;
					case 's': return Language.SWS;
					case 't': return Language.SWT;
					case 'u': return Language.SWU;
					case 'v': return Language.SWV;
					case 'w': return Language.SWW;
					case 'x': return Language.SWX;
					case 'y': return Language.SWY;
				}
				offset--;
			}
			return Language.SW;
		}

		private static Language? tryParseFromLanguage_sb(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.SBA;
					case 'b': return Language.SBB;
					case 'c': return Language.SBC;
					case 'd': return Language.SBD;
					case 'e': return Language.SBE;
					case 'f': return Language.SBF;
					case 'g': return Language.SBG;
					case 'h': return Language.SBH;
					case 'i': return Language.SBI;
					case 'j': return Language.SBJ;
					case 'k': return Language.SBK;
					case 'l': return Language.SBL;
					case 'm': return Language.SBM;
					case 'n': return Language.SBN;
					case 'o': return Language.SBO;
					case 'p': return Language.SBP;
					case 'q': return Language.SBQ;
					case 'r': return Language.SBR;
					case 's': return Language.SBS;
					case 't': return Language.SBT;
					case 'u': return Language.SBU;
					case 'v': return Language.SBV;
					case 'w': return Language.SBW;
					case 'x': return Language.SBX;
					case 'y': return Language.SBY;
					case 'z': return Language.SBZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_sf(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.SFB;
					case 'e': return Language.SFE;
					case 'm': return Language.SFM;
					case 's': return Language.SFS;
					case 'w': return Language.SFW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_sj(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.SJA;
					case 'b': return Language.SJB;
					case 'd': return Language.SJD;
					case 'e': return Language.SJE;
					case 'g': return Language.SJG;
					case 'k': return Language.SJK;
					case 'l': return Language.SJL;
					case 'm': return Language.SJM;
					case 'n': return Language.SJN;
					case 'o': return Language.SJO;
					case 'p': return Language.SJP;
					case 'r': return Language.SJR;
					case 's': return Language.SJS;
					case 't': return Language.SJT;
					case 'u': return Language.SJU;
					case 'w': return Language.SJW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_sp(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.SPB;
					case 'c': return Language.SPC;
					case 'd': return Language.SPD;
					case 'e': return Language.SPE;
					case 'g': return Language.SPG;
					case 'i': return Language.SPI;
					case 'k': return Language.SPK;
					case 'l': return Language.SPL;
					case 'm': return Language.SPM;
					case 'n': return Language.SPN;
					case 'o': return Language.SPO;
					case 'p': return Language.SPP;
					case 'q': return Language.SPQ;
					case 'r': return Language.SPR;
					case 's': return Language.SPS;
					case 't': return Language.SPT;
					case 'u': return Language.SPU;
					case 'v': return Language.SPV;
					case 'x': return Language.SPX;
					case 'y': return Language.SPY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_sx(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.SXB;
					case 'c': return Language.SXC;
					case 'e': return Language.SXE;
					case 'g': return Language.SXG;
					case 'k': return Language.SXK;
					case 'l': return Language.SXL;
					case 'm': return Language.SXM;
					case 'n': return Language.SXN;
					case 'o': return Language.SXO;
					case 'r': return Language.SXR;
					case 's': return Language.SXS;
					case 'u': return Language.SXU;
					case 'w': return Language.SXW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_sy(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.SYA;
					case 'b': return Language.SYB;
					case 'c': return Language.SYC;
					case 'd': return Language.SYD;
					case 'i': return Language.SYI;
					case 'k': return Language.SYK;
					case 'l': return Language.SYL;
					case 'm': return Language.SYM;
					case 'n': return Language.SYN;
					case 'o': return Language.SYO;
					case 'r': return Language.SYR;
					case 's': return Language.SYS;
					case 'w': return Language.SYW;
					case 'x': return Language.SYX;
					case 'y': return Language.SYY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_sz(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.SZA;
					case 'b': return Language.SZB;
					case 'c': return Language.SZC;
					case 'd': return Language.SZD;
					case 'e': return Language.SZE;
					case 'g': return Language.SZG;
					case 'l': return Language.SZL;
					case 'n': return Language.SZN;
					case 'p': return Language.SZP;
					case 'v': return Language.SZV;
					case 'w': return Language.SZW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_t(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return tryParseFromLanguage_ta(text, ref offset);
					case 'e': return tryParseFromLanguage_te(text, ref offset);
					case 'g': return tryParseFromLanguage_tg(text, ref offset);
					case 'h': return tryParseFromLanguage_th(text, ref offset);
					case 'i': return tryParseFromLanguage_ti(text, ref offset);
					case 'k': return tryParseFromLanguage_tk(text, ref offset);
					case 'l': return tryParseFromLanguage_tl(text, ref offset);
					case 'n': return tryParseFromLanguage_tn(text, ref offset);
					case 'o': return tryParseFromLanguage_to(text, ref offset);
					case 'r': return tryParseFromLanguage_tr(text, ref offset);
					case 's': return tryParseFromLanguage_ts(text, ref offset);
					case 't': return tryParseFromLanguage_tt(text, ref offset);
					case 'w': return tryParseFromLanguage_tw(text, ref offset);
					case 'y': return tryParseFromLanguage_ty(text, ref offset);
					case 'b': return tryParseFromLanguage_tb(text, ref offset);
					case 'c': return tryParseFromLanguage_tc(text, ref offset);
					case 'd': return tryParseFromLanguage_td(text, ref offset);
					case 'f': return tryParseFromLanguage_tf(text, ref offset);
					case 'j': return tryParseFromLanguage_tj(text, ref offset);
					case 'm': return tryParseFromLanguage_tm(text, ref offset);
					case 'p': return tryParseFromLanguage_tp(text, ref offset);
					case 'q': return tryParseFromLanguage_tq(text, ref offset);
					case 'u': return tryParseFromLanguage_tu(text, ref offset);
					case 'v': return tryParseFromLanguage_tv(text, ref offset);
					case 'x': return tryParseFromLanguage_tx(text, ref offset);
					case 'z': return tryParseFromLanguage_tz(text, ref offset);
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ta(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.TAA;
					case 'b': return Language.TAB;
					case 'c': return Language.TAC;
					case 'd': return Language.TAD;
					case 'e': return Language.TAE;
					case 'f': return Language.TAF;
					case 'g': return Language.TAG;
					case 'i': return Language.TAI;
					case 'j': return Language.TAJ;
					case 'k': return Language.TAK;
					case 'l': return Language.TAL;
					case 'n': return Language.TAN;
					case 'o': return Language.TAO;
					case 'p': return Language.TAP;
					case 'q': return Language.TAQ;
					case 'r': return Language.TAR;
					case 's': return Language.TAS;
					case 'u': return Language.TAU;
					case 'v': return Language.TAV;
					case 'w': return Language.TAW;
					case 'x': return Language.TAX;
					case 'y': return Language.TAY;
					case 'z': return Language.TAZ;
				}
				offset--;
			}
			return Language.TA;
		}

		private static Language? tryParseFromLanguage_te(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.TEA;
					case 'b': return Language.TEB;
					case 'c': return Language.TEC;
					case 'd': return Language.TED;
					case 'e': return Language.TEE;
					case 'f': return Language.TEF;
					case 'g': return Language.TEG;
					case 'h': return Language.TEH;
					case 'i': return Language.TEI;
					case 'k': return Language.TEK;
					case 'm': return Language.TEM;
					case 'n': return Language.TEN;
					case 'o': return Language.TEO;
					case 'p': return Language.TEP;
					case 'q': return Language.TEQ;
					case 'r': return Language.TER;
					case 's': return Language.TES;
					case 't': return Language.TET;
					case 'u': return Language.TEU;
					case 'v': return Language.TEV;
					case 'w': return Language.TEW;
					case 'x': return Language.TEX;
					case 'y': return Language.TEY;
				}
				offset--;
			}
			return Language.TE;
		}

		private static Language? tryParseFromLanguage_tg(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.TGA;
					case 'b': return Language.TGB;
					case 'c': return Language.TGC;
					case 'd': return Language.TGD;
					case 'e': return Language.TGE;
					case 'f': return Language.TGF;
					case 'g': return Language.TGG;
					case 'h': return Language.TGH;
					case 'i': return Language.TGI;
					case 'j': return Language.TGJ;
					case 'n': return Language.TGN;
					case 'o': return Language.TGO;
					case 'p': return Language.TGP;
					case 'q': return Language.TGQ;
					case 'r': return Language.TGR;
					case 's': return Language.TGS;
					case 't': return Language.TGT;
					case 'u': return Language.TGU;
					case 'v': return Language.TGV;
					case 'w': return Language.TGW;
					case 'x': return Language.TGX;
					case 'y': return Language.TGY;
					case 'z': return Language.TGZ;
				}
				offset--;
			}
			return Language.TG;
		}

		private static Language? tryParseFromLanguage_th(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'c': return Language.TPO;
					case 'd': return Language.THD;
					case 'e': return Language.THE;
					case 'f': return Language.THF;
					case 'h': return Language.THH;
					case 'i': return Language.THI;
					case 'k': return Language.THK;
					case 'l': return Language.THL;
					case 'm': return Language.THM;
					case 'n': return Language.THN;
					case 'p': return Language.THP;
					case 'q': return Language.THQ;
					case 'r': return Language.THR;
					case 's': return Language.THS;
					case 't': return Language.THT;
					case 'u': return Language.THU;
					case 'v': return Language.THV;
					case 'w': return Language.THW;
					case 'x': return Language.OYB;
					case 'y': return Language.THY;
					case 'z': return Language.THZ;
				}
				offset--;
			}
			return Language.TH;
		}

		private static Language? tryParseFromLanguage_ti(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.TIA;
					case 'c': return Language.TIC;
					case 'd': return Language.TID;
					case 'e': return Language.RAS;
					case 'f': return Language.TIF;
					case 'g': return Language.TIG;
					case 'h': return Language.TIH;
					case 'i': return Language.TII;
					case 'j': return Language.TIJ;
					case 'k': return Language.TIK;
					case 'l': return Language.TIL;
					case 'm': return Language.TIM;
					case 'n': return Language.TIN;
					case 'o': return Language.TIO;
					case 'p': return Language.TIP;
					case 'q': return Language.TIQ;
					case 's': return Language.TIS;
					case 't': return Language.TIT;
					case 'u': return Language.TIU;
					case 'v': return Language.TIV;
					case 'w': return Language.TIW;
					case 'x': return Language.TIX;
					case 'y': return Language.TIY;
					case 'z': return Language.TIZ;
				}
				offset--;
			}
			return Language.TI;
		}

		private static Language? tryParseFromLanguage_tk(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.TKA;
					case 'b': return Language.TKB;
					case 'd': return Language.TKD;
					case 'e': return Language.TKE;
					case 'f': return Language.TKF;
					case 'g': return Language.TKG;
					case 'k': return Language.TWM;
					case 'l': return Language.TKL;
					case 'm': return Language.TKM;
					case 'n': return Language.TKN;
					case 'p': return Language.TKP;
					case 'q': return Language.TKQ;
					case 'r': return Language.TKR;
					case 's': return Language.TKS;
					case 't': return Language.TKT;
					case 'u': return Language.TKU;
					case 'v': return Language.TKV;
					case 'w': return Language.TKW;
					case 'x': return Language.TKX;
					case 'z': return Language.TKZ;
				}
				offset--;
			}
			return Language.TK;
		}

		private static Language? tryParseFromLanguage_tl(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.TLA;
					case 'b': return Language.TLB;
					case 'c': return Language.TLC;
					case 'd': return Language.TLD;
					case 'f': return Language.TLF;
					case 'g': return Language.TLG;
					case 'h': return Language.TLH;
					case 'i': return Language.TLI;
					case 'j': return Language.TLJ;
					case 'k': return Language.TLK;
					case 'l': return Language.TLL;
					case 'm': return Language.TLM;
					case 'n': return Language.TLN;
					case 'o': return Language.TLO;
					case 'p': return Language.TLP;
					case 'q': return Language.TLQ;
					case 'r': return Language.TLR;
					case 's': return Language.TLS;
					case 't': return Language.TLT;
					case 'u': return Language.TLU;
					case 'v': return Language.TLV;
					case 'w': return Language.WEO;
					case 'x': return Language.TLX;
					case 'y': return Language.TLY;
				}
				offset--;
			}
			return Language.TL;
		}

		private static Language? tryParseFromLanguage_tn(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.TNA;
					case 'b': return Language.TNB;
					case 'c': return Language.TNC;
					case 'd': return Language.TND;
					case 'e': return Language.KAK;
					case 'f': return Language.PRS;
					case 'g': return Language.TNG;
					case 'h': return Language.TNH;
					case 'i': return Language.TNI;
					case 'k': return Language.TNK;
					case 'l': return Language.TNL;
					case 'm': return Language.TNM;
					case 'n': return Language.TNN;
					case 'o': return Language.TNO;
					case 'p': return Language.TNP;
					case 'q': return Language.TNQ;
					case 'r': return Language.TNR;
					case 's': return Language.TNS;
					case 't': return Language.TNT;
					case 'u': return Language.TNU;
					case 'v': return Language.TNV;
					case 'w': return Language.TNW;
					case 'x': return Language.TNX;
					case 'y': return Language.TNY;
					case 'z': return Language.TNZ;
				}
				offset--;
			}
			return Language.TN;
		}

		private static Language? tryParseFromLanguage_to(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.TOB;
					case 'c': return Language.TOC;
					case 'd': return Language.TOD;
					case 'e': return Language.TOE;
					case 'f': return Language.TOF;
					case 'g': return Language.TOG;
					case 'h': return Language.TOH;
					case 'i': return Language.TOI;
					case 'j': return Language.TOJ;
					case 'l': return Language.TOL;
					case 'm': return Language.TOM;
					case 'o': return Language.TOO;
					case 'p': return Language.TOP;
					case 'q': return Language.TOQ;
					case 'r': return Language.TOR;
					case 's': return Language.TOS;
					case 'u': return Language.TOU;
					case 'v': return Language.TOV;
					case 'w': return Language.TOW;
					case 'x': return Language.TOX;
					case 'y': return Language.TOY;
					case 'z': return Language.TOZ;
				}
				offset--;
			}
			return Language.TO;
		}

		private static Language? tryParseFromLanguage_tr(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.TRA;
					case 'b': return Language.TRB;
					case 'c': return Language.TRC;
					case 'd': return Language.TRD;
					case 'e': return Language.TRE;
					case 'f': return Language.TRF;
					case 'g': return Language.TRG;
					case 'h': return Language.TRH;
					case 'i': return Language.TRI;
					case 'j': return Language.TRJ;
					case 'k': return Language.TRK;
					case 'l': return Language.TRL;
					case 'm': return Language.TRM;
					case 'n': return Language.TRN;
					case 'o': return Language.TRO;
					case 'p': return Language.TRP;
					case 'q': return Language.TRQ;
					case 'r': return Language.TRR;
					case 's': return Language.TRS;
					case 't': return Language.TRT;
					case 'u': return Language.TRU;
					case 'v': return Language.TRV;
					case 'w': return Language.TRW;
					case 'x': return Language.TRX;
					case 'y': return Language.TRY;
					case 'z': return Language.TRZ;
				}
				offset--;
			}
			return Language.TR;
		}

		private static Language? tryParseFromLanguage_ts(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.TSA;
					case 'b': return Language.TSB;
					case 'c': return Language.TSC;
					case 'd': return Language.TSD;
					case 'e': return Language.TSE;
					case 'f': return Language.TAJ;
					case 'g': return Language.TSG;
					case 'h': return Language.TSH;
					case 'i': return Language.TSI;
					case 'j': return Language.TSJ;
					case 'k': return Language.TSK;
					case 'l': return Language.TSL;
					case 'm': return Language.TSM;
					case 'p': return Language.TSP;
					case 'q': return Language.TSQ;
					case 'r': return Language.TSR;
					case 's': return Language.TSS;
					case 't': return Language.TST;
					case 'u': return Language.TSU;
					case 'v': return Language.TSV;
					case 'w': return Language.TSW;
					case 'x': return Language.TSX;
					case 'y': return Language.TSY;
					case 'z': return Language.TSZ;
				}
				offset--;
			}
			return Language.TS;
		}

		private static Language? tryParseFromLanguage_tt(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.TTA;
					case 'b': return Language.TTB;
					case 'c': return Language.TTC;
					case 'd': return Language.TTD;
					case 'e': return Language.TTE;
					case 'f': return Language.TTF;
					case 'g': return Language.TTG;
					case 'h': return Language.TTH;
					case 'i': return Language.TTI;
					case 'j': return Language.TTJ;
					case 'k': return Language.TTK;
					case 'l': return Language.TTL;
					case 'm': return Language.TTM;
					case 'n': return Language.TTN;
					case 'o': return Language.TTO;
					case 'p': return Language.TTP;
					case 'q': return Language.TTQ;
					case 'r': return Language.TTR;
					case 's': return Language.TTS;
					case 't': return Language.TTT;
					case 'u': return Language.TTU;
					case 'v': return Language.TTV;
					case 'w': return Language.TTW;
					case 'y': return Language.TTY;
					case 'z': return Language.TTZ;
				}
				offset--;
			}
			return Language.TT;
		}

		private static Language? tryParseFromLanguage_tw(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.TWA;
					case 'b': return Language.TWB;
					case 'c': return Language.TWC;
					case 'd': return Language.TWD;
					case 'e': return Language.TWE;
					case 'f': return Language.TWF;
					case 'g': return Language.TWG;
					case 'h': return Language.TWH;
					case 'l': return Language.TWL;
					case 'm': return Language.TWM;
					case 'n': return Language.TWN;
					case 'o': return Language.TWO;
					case 'p': return Language.TWP;
					case 'q': return Language.TWQ;
					case 'r': return Language.TWR;
					case 't': return Language.TWT;
					case 'u': return Language.TWU;
					case 'w': return Language.TWW;
					case 'x': return Language.TWX;
					case 'y': return Language.TWY;
				}
				offset--;
			}
			return Language.TW;
		}

		private static Language? tryParseFromLanguage_ty(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.TYA;
					case 'e': return Language.TYE;
					case 'h': return Language.TYH;
					case 'i': return Language.TYI;
					case 'j': return Language.TYJ;
					case 'l': return Language.TYL;
					case 'n': return Language.TYN;
					case 'p': return Language.TYP;
					case 'r': return Language.TYR;
					case 's': return Language.TYS;
					case 't': return Language.TYT;
					case 'u': return Language.TYU;
					case 'v': return Language.TYV;
					case 'x': return Language.TYX;
					case 'z': return Language.TYZ;
				}
				offset--;
			}
			return Language.TY;
		}

		private static Language? tryParseFromLanguage_tb(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.TBA;
					case 'b': return Language.TBB;
					case 'c': return Language.TBC;
					case 'd': return Language.TBD;
					case 'e': return Language.TBE;
					case 'f': return Language.TBF;
					case 'g': return Language.TBG;
					case 'h': return Language.TBH;
					case 'i': return Language.TBI;
					case 'j': return Language.TBJ;
					case 'k': return Language.TBK;
					case 'l': return Language.TBL;
					case 'm': return Language.TBM;
					case 'n': return Language.TBN;
					case 'o': return Language.TBO;
					case 'p': return Language.TBP;
					case 'q': return Language.TBQ;
					case 'r': return Language.TBR;
					case 's': return Language.TBS;
					case 't': return Language.TBT;
					case 'u': return Language.TBU;
					case 'v': return Language.TBV;
					case 'w': return Language.TBW;
					case 'x': return Language.TBX;
					case 'y': return Language.TBY;
					case 'z': return Language.TBZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_tc(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.TCA;
					case 'b': return Language.TCB;
					case 'c': return Language.TCC;
					case 'd': return Language.TCD;
					case 'e': return Language.TCE;
					case 'f': return Language.TCF;
					case 'g': return Language.TCG;
					case 'h': return Language.TCH;
					case 'i': return Language.TCI;
					case 'k': return Language.TCK;
					case 'l': return Language.TCL;
					case 'm': return Language.TCM;
					case 'n': return Language.TCN;
					case 'o': return Language.TCO;
					case 'p': return Language.TCP;
					case 'q': return Language.TCQ;
					case 's': return Language.TCS;
					case 't': return Language.TCT;
					case 'u': return Language.TCU;
					case 'w': return Language.TCW;
					case 'x': return Language.TCX;
					case 'y': return Language.TCY;
					case 'z': return Language.TCZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_td(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.TDA;
					case 'b': return Language.TDB;
					case 'c': return Language.TDC;
					case 'd': return Language.TDD;
					case 'e': return Language.TDE;
					case 'f': return Language.TDF;
					case 'g': return Language.TDG;
					case 'h': return Language.TDH;
					case 'i': return Language.TDI;
					case 'j': return Language.TDJ;
					case 'k': return Language.TDK;
					case 'l': return Language.TDL;
					case 'm': return Language.TDM;
					case 'n': return Language.TDN;
					case 'o': return Language.TDO;
					case 'q': return Language.TDQ;
					case 'r': return Language.TDR;
					case 's': return Language.TDS;
					case 't': return Language.TDT;
					case 'u': return Language.DTP;
					case 'v': return Language.TDV;
					case 'x': return Language.TDX;
					case 'y': return Language.TDY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_tf(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'i': return Language.TFI;
					case 'n': return Language.TFN;
					case 'o': return Language.TFO;
					case 'r': return Language.TFR;
					case 't': return Language.TFT;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_tj(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.TJA;
					case 'g': return Language.TJG;
					case 'i': return Language.TJI;
					case 'l': return Language.TJL;
					case 'm': return Language.TJM;
					case 'n': return Language.TJN;
					case 'o': return Language.TJO;
					case 's': return Language.TJS;
					case 'u': return Language.TJU;
					case 'w': return Language.TJW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_tm(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.TMA;
					case 'b': return Language.TMB;
					case 'c': return Language.TMC;
					case 'd': return Language.TMD;
					case 'e': return Language.TME;
					case 'f': return Language.TMF;
					case 'g': return Language.TMG;
					case 'h': return Language.TMH;
					case 'i': return Language.TMI;
					case 'j': return Language.TMJ;
					case 'k': return Language.TMK;
					case 'l': return Language.TML;
					case 'm': return Language.TMM;
					case 'n': return Language.TMN;
					case 'o': return Language.TMO;
					case 'p': return Language.TYJ;
					case 'q': return Language.TMQ;
					case 'r': return Language.TMR;
					case 's': return Language.TMS;
					case 't': return Language.TMT;
					case 'u': return Language.TMU;
					case 'v': return Language.TMV;
					case 'w': return Language.TMW;
					case 'y': return Language.TMY;
					case 'z': return Language.TMZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_tp(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.TPA;
					case 'c': return Language.TPC;
					case 'e': return Language.TPE;
					case 'f': return Language.TPF;
					case 'g': return Language.TPG;
					case 'i': return Language.TPI;
					case 'j': return Language.TPJ;
					case 'k': return Language.TPK;
					case 'l': return Language.TPL;
					case 'm': return Language.TPM;
					case 'n': return Language.TPN;
					case 'o': return Language.TPO;
					case 'p': return Language.TPP;
					case 'q': return Language.TPQ;
					case 'r': return Language.TPR;
					case 't': return Language.TPT;
					case 'u': return Language.TPU;
					case 'v': return Language.TPV;
					case 'w': return Language.TPW;
					case 'x': return Language.TPX;
					case 'y': return Language.TPY;
					case 'z': return Language.TPZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_tq(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.TQB;
					case 'l': return Language.TQL;
					case 'm': return Language.TQM;
					case 'n': return Language.TQN;
					case 'o': return Language.TQO;
					case 'p': return Language.TQP;
					case 'q': return Language.TQQ;
					case 'r': return Language.TQR;
					case 't': return Language.TQT;
					case 'u': return Language.TQU;
					case 'w': return Language.TQW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_tu(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.TUA;
					case 'b': return Language.TUB;
					case 'c': return Language.TUC;
					case 'd': return Language.TUD;
					case 'e': return Language.TUE;
					case 'f': return Language.TUF;
					case 'g': return Language.TUG;
					case 'h': return Language.TUH;
					case 'i': return Language.TUI;
					case 'j': return Language.TUJ;
					case 'l': return Language.TUL;
					case 'm': return Language.TUM;
					case 'n': return Language.TUN;
					case 'o': return Language.TUO;
					case 'p': return Language.TUP;
					case 'q': return Language.TUQ;
					case 's': return Language.TUS;
					case 't': return Language.TUT;
					case 'u': return Language.TUU;
					case 'v': return Language.TUV;
					case 'w': return Language.TUW;
					case 'x': return Language.TUX;
					case 'y': return Language.TUY;
					case 'z': return Language.TUZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_tv(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.TVA;
					case 'd': return Language.TVD;
					case 'e': return Language.TVE;
					case 'k': return Language.TVK;
					case 'l': return Language.TVL;
					case 'm': return Language.TVM;
					case 'n': return Language.TVN;
					case 'o': return Language.TVO;
					case 's': return Language.TVS;
					case 't': return Language.TVT;
					case 'u': return Language.TVU;
					case 'w': return Language.TVW;
					case 'y': return Language.TVY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_tx(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.TXA;
					case 'b': return Language.TXB;
					case 'c': return Language.TXC;
					case 'e': return Language.TXE;
					case 'g': return Language.TXG;
					case 'h': return Language.TXH;
					case 'i': return Language.TXI;
					case 'j': return Language.TXJ;
					case 'm': return Language.TXM;
					case 'n': return Language.TXN;
					case 'o': return Language.TXO;
					case 'q': return Language.TXQ;
					case 'r': return Language.TXR;
					case 's': return Language.TXS;
					case 't': return Language.TXT;
					case 'u': return Language.TXU;
					case 'x': return Language.TXX;
					case 'y': return Language.TXY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_tz(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.TZA;
					case 'h': return Language.TZH;
					case 'j': return Language.TZJ;
					case 'l': return Language.TZL;
					case 'm': return Language.TZM;
					case 'n': return Language.TZN;
					case 'o': return Language.TZO;
					case 'x': return Language.TZX;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_u(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'g': return tryParseFromLanguage_ug(text, ref offset);
					case 'k': return tryParseFromLanguage_uk(text, ref offset);
					case 'r': return tryParseFromLanguage_ur(text, ref offset);
					case 'z': return tryParseFromLanguage_uz(text, ref offset);
					case 'a': return tryParseFromLanguage_ua(text, ref offset);
					case 'b': return tryParseFromLanguage_ub(text, ref offset);
					case 'd': return tryParseFromLanguage_ud(text, ref offset);
					case 'e': return tryParseFromLanguage_ue(text, ref offset);
					case 'f': return tryParseFromLanguage_uf(text, ref offset);
					case 'h': return tryParseFromLanguage_uh(text, ref offset);
					case 'i': return tryParseFromLanguage_ui(text, ref offset);
					case 'j': return tryParseFromLanguage_uj(text, ref offset);
					case 'l': return tryParseFromLanguage_ul(text, ref offset);
					case 'm': return tryParseFromLanguage_um(text, ref offset);
					case 'n': return tryParseFromLanguage_un(text, ref offset);
					case 'o': return tryParseFromLanguage_uo(text, ref offset);
					case 'p': return tryParseFromLanguage_up(text, ref offset);
					case 's': return tryParseFromLanguage_us(text, ref offset);
					case 't': return tryParseFromLanguage_ut(text, ref offset);
					case 'u': return tryParseFromLanguage_uu(text, ref offset);
					case 'v': return tryParseFromLanguage_uv(text, ref offset);
					case 'w': return tryParseFromLanguage_uw(text, ref offset);
					case 'y': return tryParseFromLanguage_uy(text, ref offset);
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ug(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.UGA;
					case 'b': return Language.UGB;
					case 'e': return Language.UGE;
					case 'n': return Language.UGN;
					case 'o': return Language.UGO;
					case 'y': return Language.UGY;
				}
				offset--;
			}
			return Language.UG;
		}

		private static Language? tryParseFromLanguage_uk(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.UKA;
					case 'g': return Language.UKG;
					case 'h': return Language.UKH;
					case 'l': return Language.UKL;
					case 'p': return Language.UKP;
					case 'q': return Language.UKQ;
					case 's': return Language.UKS;
					case 'u': return Language.UKU;
					case 'w': return Language.UKW;
					case 'y': return Language.UKY;
				}
				offset--;
			}
			return Language.UK;
		}

		private static Language? tryParseFromLanguage_ur(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.URA;
					case 'b': return Language.URB;
					case 'c': return Language.URC;
					case 'e': return Language.URE;
					case 'f': return Language.URF;
					case 'g': return Language.URG;
					case 'h': return Language.URH;
					case 'i': return Language.URI;
					case 'j': return Language.URJ;
					case 'k': return Language.URK;
					case 'l': return Language.URL;
					case 'm': return Language.URM;
					case 'n': return Language.URN;
					case 'o': return Language.URO;
					case 'p': return Language.URP;
					case 'r': return Language.URR;
					case 't': return Language.URT;
					case 'u': return Language.URU;
					case 'v': return Language.URV;
					case 'w': return Language.URW;
					case 'x': return Language.URX;
					case 'y': return Language.URY;
					case 'z': return Language.URZ;
				}
				offset--;
			}
			return Language.UR;
		}

		private static Language? tryParseFromLanguage_uz(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'n': return Language.UZN;
					case 's': return Language.UZS;
				}
				offset--;
			}
			return Language.UZ;
		}

		private static Language? tryParseFromLanguage_ua(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'm': return Language.UAM;
					case 'n': return Language.UAN;
					case 'r': return Language.UAR;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ub(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.UBA;
					case 'i': return Language.UBI;
					case 'l': return Language.UBL;
					case 'r': return Language.UBR;
					case 'u': return Language.UBU;
					case 'y': return Language.UBY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ud(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.UDA;
					case 'e': return Language.UDE;
					case 'g': return Language.UDG;
					case 'i': return Language.UDI;
					case 'j': return Language.UDJ;
					case 'l': return Language.UDL;
					case 'm': return Language.UDM;
					case 'u': return Language.UDU;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ue(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 's': return Language.UES;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_uf(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'i': return Language.UFI;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_uh(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.UHA;
					case 'n': return Language.UHN;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ui(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 's': return Language.UIS;
					case 'v': return Language.UIV;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_uj(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'i': return Language.UJI;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ul(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.ULA;
					case 'b': return Language.ULB;
					case 'c': return Language.ULC;
					case 'e': return Language.ULE;
					case 'f': return Language.ULF;
					case 'i': return Language.ULI;
					case 'k': return Language.ULK;
					case 'l': return Language.ULL;
					case 'm': return Language.ULM;
					case 'n': return Language.ULN;
					case 'u': return Language.ULU;
					case 'w': return Language.ULW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_um(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.UMA;
					case 'b': return Language.UMB;
					case 'c': return Language.UMC;
					case 'd': return Language.UMD;
					case 'g': return Language.UMG;
					case 'i': return Language.UMI;
					case 'm': return Language.UMM;
					case 'n': return Language.UMN;
					case 'o': return Language.UMO;
					case 'p': return Language.UMP;
					case 'r': return Language.UMR;
					case 's': return Language.UMS;
					case 'u': return Language.UMU;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_un(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.UNA;
					case 'd': return Language.UND;
					case 'e': return Language.UNE;
					case 'g': return Language.UNG;
					case 'k': return Language.UNK;
					case 'm': return Language.UNM;
					case 'n': return Language.UNN;
					case 'p': return Language.UNP;
					case 'r': return Language.UNR;
					case 'u': return Language.UNU;
					case 'x': return Language.UNX;
					case 'z': return Language.UNZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_uo(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'k': return Language.EMA;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_up(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'i': return Language.UPI;
					case 'v': return Language.UPV;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_us(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.USA;
					case 'h': return Language.USH;
					case 'i': return Language.USI;
					case 'k': return Language.USK;
					case 'p': return Language.USP;
					case 'u': return Language.USU;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ut(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.UTA;
					case 'e': return Language.UTE;
					case 'p': return Language.UTP;
					case 'r': return Language.UTR;
					case 'u': return Language.UTU;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_uu(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'm': return Language.UUM;
					case 'n': return Language.UUN;
					case 'r': return Language.UUR;
					case 'u': return Language.UUU;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_uv(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'e': return Language.UVE;
					case 'h': return Language.UVH;
					case 'l': return Language.UVL;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_uw(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.UWA;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_uy(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.UYA;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_v(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'e': return tryParseFromLanguage_ve(text, ref offset);
					case 'i': return tryParseFromLanguage_vi(text, ref offset);
					case 'o': return tryParseFromLanguage_vo(text, ref offset);
					case 'a': return tryParseFromLanguage_va(text, ref offset);
					case 'b': return tryParseFromLanguage_vb(text, ref offset);
					case 'g': return tryParseFromLanguage_vg(text, ref offset);
					case 'k': return tryParseFromLanguage_vk(text, ref offset);
					case 'l': return tryParseFromLanguage_vl(text, ref offset);
					case 'm': return tryParseFromLanguage_vm(text, ref offset);
					case 'n': return tryParseFromLanguage_vn(text, ref offset);
					case 'r': return tryParseFromLanguage_vr(text, ref offset);
					case 's': return tryParseFromLanguage_vs(text, ref offset);
					case 't': return tryParseFromLanguage_vt(text, ref offset);
					case 'u': return tryParseFromLanguage_vu(text, ref offset);
					case 'w': return tryParseFromLanguage_vw(text, ref offset);
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ve(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'c': return Language.VEC;
					case 'd': return Language.VED;
					case 'l': return Language.VEL;
					case 'm': return Language.VEM;
					case 'o': return Language.VEO;
					case 'p': return Language.VEP;
					case 'r': return Language.VER;
				}
				offset--;
			}
			return Language.VE;
		}

		private static Language? tryParseFromLanguage_vi(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'c': return Language.VIC;
					case 'd': return Language.VID;
					case 'f': return Language.VIF;
					case 'g': return Language.VIG;
					case 'l': return Language.VIL;
					case 'n': return Language.VIN;
					case 's': return Language.VIS;
					case 't': return Language.VIT;
					case 'v': return Language.VIV;
				}
				offset--;
			}
			return Language.VI;
		}

		private static Language? tryParseFromLanguage_vo(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'r': return Language.VOR;
					case 't': return Language.VOT;
				}
				offset--;
			}
			return Language.VO;
		}

		private static Language? tryParseFromLanguage_va(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.VAA;
					case 'e': return Language.VAE;
					case 'f': return Language.VAF;
					case 'g': return Language.VAG;
					case 'h': return Language.VAH;
					case 'i': return Language.VAI;
					case 'j': return Language.VAJ;
					case 'l': return Language.VAL;
					case 'm': return Language.VAM;
					case 'n': return Language.VAN;
					case 'o': return Language.VAO;
					case 'p': return Language.VAP;
					case 'r': return Language.VAR;
					case 's': return Language.VAS;
					case 'u': return Language.VAU;
					case 'v': return Language.VAV;
					case 'y': return Language.VAY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_vb(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.VBB;
					case 'k': return Language.VBK;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_vg(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'r': return Language.VGR;
					case 't': return Language.VGT;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_vk(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.VKA;
					case 'i': return Language.VKI;
					case 'j': return Language.VKJ;
					case 'k': return Language.VKK;
					case 'l': return Language.VKL;
					case 'm': return Language.VKM;
					case 'o': return Language.VKO;
					case 'p': return Language.VKP;
					case 't': return Language.VKT;
					case 'u': return Language.VKU;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_vl(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'p': return Language.VLP;
					case 's': return Language.VLS;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_vm(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.VMA;
					case 'b': return Language.VMB;
					case 'c': return Language.VMC;
					case 'd': return Language.VMD;
					case 'e': return Language.VME;
					case 'f': return Language.VMF;
					case 'g': return Language.VMG;
					case 'h': return Language.VMH;
					case 'i': return Language.VMI;
					case 'j': return Language.VMJ;
					case 'k': return Language.VMK;
					case 'l': return Language.VML;
					case 'm': return Language.VMM;
					case 'p': return Language.VMP;
					case 'q': return Language.VMQ;
					case 'r': return Language.VMR;
					case 's': return Language.VMS;
					case 'u': return Language.VMU;
					case 'v': return Language.VMV;
					case 'w': return Language.VMW;
					case 'x': return Language.VMX;
					case 'y': return Language.VMY;
					case 'z': return Language.VMZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_vn(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'k': return Language.VNK;
					case 'm': return Language.VNM;
					case 'p': return Language.VNP;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_vr(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.VRA;
					case 'o': return Language.VRO;
					case 's': return Language.VRS;
					case 't': return Language.VRT;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_vs(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'i': return Language.VSI;
					case 'l': return Language.VSL;
					case 'v': return Language.VSV;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_vt(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'o': return Language.VTO;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_vu(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'm': return Language.VUM;
					case 'n': return Language.VUN;
					case 't': return Language.VUT;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_vw(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.VWA;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_w(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return tryParseFromLanguage_wa(text, ref offset);
					case 'o': return tryParseFromLanguage_wo(text, ref offset);
					case 'b': return tryParseFromLanguage_wb(text, ref offset);
					case 'c': return tryParseFromLanguage_wc(text, ref offset);
					case 'd': return tryParseFromLanguage_wd(text, ref offset);
					case 'e': return tryParseFromLanguage_we(text, ref offset);
					case 'f': return tryParseFromLanguage_wf(text, ref offset);
					case 'g': return tryParseFromLanguage_wg(text, ref offset);
					case 'h': return tryParseFromLanguage_wh(text, ref offset);
					case 'i': return tryParseFromLanguage_wi(text, ref offset);
					case 'j': return tryParseFromLanguage_wj(text, ref offset);
					case 'k': return tryParseFromLanguage_wk(text, ref offset);
					case 'l': return tryParseFromLanguage_wl(text, ref offset);
					case 'm': return tryParseFromLanguage_wm(text, ref offset);
					case 'n': return tryParseFromLanguage_wn(text, ref offset);
					case 'p': return tryParseFromLanguage_wp(text, ref offset);
					case 'r': return tryParseFromLanguage_wr(text, ref offset);
					case 's': return tryParseFromLanguage_ws(text, ref offset);
					case 't': return tryParseFromLanguage_wt(text, ref offset);
					case 'u': return tryParseFromLanguage_wu(text, ref offset);
					case 'w': return tryParseFromLanguage_ww(text, ref offset);
					case 'x': return tryParseFromLanguage_wx(text, ref offset);
					case 'y': return tryParseFromLanguage_wy(text, ref offset);
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_wa(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.WAA;
					case 'b': return Language.WAB;
					case 'c': return Language.WAC;
					case 'd': return Language.WAD;
					case 'e': return Language.WAE;
					case 'f': return Language.WAF;
					case 'g': return Language.WAG;
					case 'h': return Language.WAH;
					case 'i': return Language.WAI;
					case 'j': return Language.WAJ;
					case 'k': return Language.WAK;
					case 'l': return Language.WAL;
					case 'm': return Language.WAM;
					case 'n': return Language.WAN;
					case 'o': return Language.WAO;
					case 'p': return Language.WAP;
					case 'q': return Language.WAQ;
					case 'r': return Language.WAR;
					case 's': return Language.WAS;
					case 't': return Language.WAT;
					case 'u': return Language.WAU;
					case 'v': return Language.WAV;
					case 'w': return Language.WAW;
					case 'x': return Language.WAX;
					case 'y': return Language.WAY;
					case 'z': return Language.WAZ;
				}
				offset--;
			}
			return Language.WA;
		}

		private static Language? tryParseFromLanguage_wo(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.WOA;
					case 'b': return Language.WOB;
					case 'c': return Language.WOC;
					case 'd': return Language.WOD;
					case 'e': return Language.WOE;
					case 'f': return Language.WOF;
					case 'g': return Language.WOG;
					case 'i': return Language.WOI;
					case 'k': return Language.WOK;
					case 'm': return Language.WOM;
					case 'n': return Language.WON;
					case 'o': return Language.WOO;
					case 'r': return Language.WOR;
					case 's': return Language.WOS;
					case 'w': return Language.WOW;
					case 'y': return Language.WOY;
				}
				offset--;
			}
			return Language.WO;
		}

		private static Language? tryParseFromLanguage_wb(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.WBA;
					case 'b': return Language.WBB;
					case 'e': return Language.WBE;
					case 'f': return Language.WBF;
					case 'h': return Language.WBH;
					case 'i': return Language.WBI;
					case 'j': return Language.WBJ;
					case 'k': return Language.WBK;
					case 'l': return Language.WBL;
					case 'm': return Language.WBM;
					case 'p': return Language.WBP;
					case 'q': return Language.WBQ;
					case 'r': return Language.WBR;
					case 't': return Language.WBT;
					case 'v': return Language.WBV;
					case 'w': return Language.WBW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_wc(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.WCA;
					case 'i': return Language.WCI;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_wd(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'd': return Language.WDD;
					case 'g': return Language.WDG;
					case 'j': return Language.WDJ;
					case 'k': return Language.WDK;
					case 'u': return Language.WDU;
					case 'y': return Language.WDY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_we(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.WEA;
					case 'c': return Language.WEC;
					case 'd': return Language.WED;
					case 'g': return Language.WEG;
					case 'h': return Language.WEH;
					case 'i': return Language.WEI;
					case 'm': return Language.WEM;
					case 'n': return Language.WEN;
					case 'o': return Language.WEO;
					case 'p': return Language.WEP;
					case 'r': return Language.WER;
					case 's': return Language.WES;
					case 't': return Language.WET;
					case 'u': return Language.WEU;
					case 'w': return Language.WEW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_wf(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'g': return Language.WFG;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_wg(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.WGA;
					case 'b': return Language.WGB;
					case 'g': return Language.WGG;
					case 'i': return Language.WGI;
					case 'o': return Language.WGO;
					case 'u': return Language.WGU;
					case 'w': return Language.WGW;
					case 'y': return Language.WGY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_wh(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.WHA;
					case 'g': return Language.WHG;
					case 'k': return Language.WHK;
					case 'u': return Language.WHU;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_wi(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.WIB;
					case 'c': return Language.WIC;
					case 'e': return Language.WIE;
					case 'f': return Language.WIF;
					case 'g': return Language.WIG;
					case 'h': return Language.WIH;
					case 'i': return Language.WII;
					case 'j': return Language.WIJ;
					case 'k': return Language.WIK;
					case 'l': return Language.WIL;
					case 'm': return Language.WIM;
					case 'n': return Language.WIN;
					case 'r': return Language.WIR;
					case 't': return Language.WIT;
					case 'u': return Language.WIU;
					case 'v': return Language.WIV;
					case 'w': return Language.WIW;
					case 'y': return Language.WIY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_wj(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.WJA;
					case 'i': return Language.WJI;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_wk(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.WKA;
					case 'b': return Language.WKB;
					case 'd': return Language.WKD;
					case 'l': return Language.WKL;
					case 'u': return Language.WKU;
					case 'w': return Language.WKW;
					case 'y': return Language.WKY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_wl(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.WLA;
					case 'c': return Language.WLC;
					case 'e': return Language.WLE;
					case 'g': return Language.WLG;
					case 'i': return Language.WLI;
					case 'k': return Language.WLK;
					case 'l': return Language.WLL;
					case 'm': return Language.WLM;
					case 'o': return Language.WLO;
					case 'r': return Language.WLR;
					case 's': return Language.WLS;
					case 'u': return Language.WLU;
					case 'v': return Language.WLV;
					case 'w': return Language.WLW;
					case 'x': return Language.WLX;
					case 'y': return Language.WLY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_wm(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.WMA;
					case 'b': return Language.WMB;
					case 'c': return Language.WMC;
					case 'd': return Language.WMD;
					case 'e': return Language.WME;
					case 'h': return Language.WMH;
					case 'i': return Language.WMI;
					case 'm': return Language.WMM;
					case 'n': return Language.WMN;
					case 'o': return Language.WMO;
					case 's': return Language.WMS;
					case 't': return Language.WMT;
					case 'w': return Language.WMW;
					case 'x': return Language.WMX;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_wn(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.WNB;
					case 'c': return Language.WNC;
					case 'd': return Language.WND;
					case 'e': return Language.WNE;
					case 'g': return Language.WNG;
					case 'i': return Language.WNI;
					case 'k': return Language.WNK;
					case 'm': return Language.WNM;
					case 'n': return Language.WNN;
					case 'o': return Language.WNO;
					case 'p': return Language.WNP;
					case 'u': return Language.WNU;
					case 'w': return Language.WNW;
					case 'y': return Language.WNY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_wp(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'c': return Language.WPC;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_wr(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.WRA;
					case 'b': return Language.WRB;
					case 'd': return Language.WRD;
					case 'g': return Language.WRG;
					case 'h': return Language.WRH;
					case 'i': return Language.WRI;
					case 'k': return Language.WRK;
					case 'l': return Language.WRL;
					case 'm': return Language.WRM;
					case 'n': return Language.WRN;
					case 'o': return Language.WRO;
					case 'p': return Language.WRP;
					case 'r': return Language.WRR;
					case 's': return Language.WRS;
					case 'u': return Language.WRU;
					case 'v': return Language.WRV;
					case 'w': return Language.WRW;
					case 'x': return Language.WRX;
					case 'y': return Language.WRY;
					case 'z': return Language.WRZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ws(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.WSA;
					case 'g': return Language.WSG;
					case 'i': return Language.WSI;
					case 'k': return Language.WSK;
					case 'r': return Language.WSR;
					case 's': return Language.WSS;
					case 'u': return Language.WSU;
					case 'v': return Language.WSV;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_wt(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'f': return Language.WTF;
					case 'h': return Language.WTH;
					case 'i': return Language.WTI;
					case 'k': return Language.WTK;
					case 'm': return Language.WTM;
					case 'w': return Language.WTW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_wu(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.WUA;
					case 'b': return Language.WUB;
					case 'd': return Language.WUD;
					case 'h': return Language.WUH;
					case 'l': return Language.WUL;
					case 'm': return Language.WUM;
					case 'n': return Language.WUN;
					case 'r': return Language.WUR;
					case 't': return Language.WUT;
					case 'u': return Language.WUU;
					case 'v': return Language.WUV;
					case 'x': return Language.WUX;
					case 'y': return Language.WUY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ww(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.WWA;
					case 'b': return Language.WWB;
					case 'o': return Language.WWO;
					case 'r': return Language.WWR;
					case 'w': return Language.WWW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_wx(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.WXA;
					case 'w': return Language.WXW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_wy(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.WYA;
					case 'b': return Language.WYB;
					case 'i': return Language.WYI;
					case 'm': return Language.WYM;
					case 'r': return Language.WYR;
					case 'y': return Language.WYY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_x(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'h': return tryParseFromLanguage_xh(text, ref offset);
					case 'a': return tryParseFromLanguage_xa(text, ref offset);
					case 'b': return tryParseFromLanguage_xb(text, ref offset);
					case 'c': return tryParseFromLanguage_xc(text, ref offset);
					case 'd': return tryParseFromLanguage_xd(text, ref offset);
					case 'e': return tryParseFromLanguage_xe(text, ref offset);
					case 'f': return tryParseFromLanguage_xf(text, ref offset);
					case 'g': return tryParseFromLanguage_xg(text, ref offset);
					case 'i': return tryParseFromLanguage_xi(text, ref offset);
					case 'j': return tryParseFromLanguage_xj(text, ref offset);
					case 'k': return tryParseFromLanguage_xk(text, ref offset);
					case 'l': return tryParseFromLanguage_xl(text, ref offset);
					case 'm': return tryParseFromLanguage_xm(text, ref offset);
					case 'n': return tryParseFromLanguage_xn(text, ref offset);
					case 'o': return tryParseFromLanguage_xo(text, ref offset);
					case 'p': return tryParseFromLanguage_xp(text, ref offset);
					case 'q': return tryParseFromLanguage_xq(text, ref offset);
					case 'r': return tryParseFromLanguage_xr(text, ref offset);
					case 's': return tryParseFromLanguage_xs(text, ref offset);
					case 't': return tryParseFromLanguage_xt(text, ref offset);
					case 'u': return tryParseFromLanguage_xu(text, ref offset);
					case 'v': return tryParseFromLanguage_xv(text, ref offset);
					case 'w': return tryParseFromLanguage_xw(text, ref offset);
					case 'x': return tryParseFromLanguage_xx(text, ref offset);
					case 'y': return tryParseFromLanguage_xy(text, ref offset);
					case 'z': return tryParseFromLanguage_xz(text, ref offset);
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_xh(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.XHA;
					case 'c': return Language.XHC;
					case 'd': return Language.XHD;
					case 'e': return Language.XHE;
					case 'r': return Language.XHR;
					case 't': return Language.XHT;
					case 'u': return Language.XHU;
					case 'v': return Language.XHV;
				}
				offset--;
			}
			return Language.XH;
		}

		private static Language? tryParseFromLanguage_xa(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.XAA;
					case 'b': return Language.XAB;
					case 'c': return Language.XAC;
					case 'd': return Language.XAD;
					case 'e': return Language.XAE;
					case 'g': return Language.XAG;
					case 'i': return Language.XAI;
					case 'j': return Language.XAJ;
					case 'k': return Language.XAK;
					case 'l': return Language.XAL;
					case 'm': return Language.XAM;
					case 'n': return Language.XAN;
					case 'o': return Language.XAO;
					case 'p': return Language.XAP;
					case 'q': return Language.XAQ;
					case 'r': return Language.XAR;
					case 's': return Language.XAS;
					case 't': return Language.XAT;
					case 'u': return Language.XAU;
					case 'v': return Language.XAV;
					case 'w': return Language.XAW;
					case 'y': return Language.XAY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_xb(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.CAX;
					case 'b': return Language.XBB;
					case 'c': return Language.XBC;
					case 'd': return Language.XBD;
					case 'e': return Language.XBE;
					case 'g': return Language.XBG;
					case 'i': return Language.XBI;
					case 'j': return Language.XBJ;
					case 'm': return Language.XBM;
					case 'n': return Language.XBN;
					case 'o': return Language.XBO;
					case 'p': return Language.XBP;
					case 'r': return Language.XBR;
					case 'w': return Language.XBW;
					case 'x': return Language.XBX;
					case 'y': return Language.XBY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_xc(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.XCB;
					case 'c': return Language.XCC;
					case 'e': return Language.XCE;
					case 'g': return Language.XCG;
					case 'h': return Language.XCH;
					case 'l': return Language.XCL;
					case 'm': return Language.XCM;
					case 'n': return Language.XCN;
					case 'o': return Language.XCO;
					case 'r': return Language.XCR;
					case 't': return Language.XCT;
					case 'u': return Language.XCU;
					case 'v': return Language.XCV;
					case 'w': return Language.XCW;
					case 'y': return Language.XCY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_xd(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.XDA;
					case 'c': return Language.XDC;
					case 'k': return Language.XDK;
					case 'm': return Language.XDM;
					case 'y': return Language.XDY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_xe(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.XEB;
					case 'd': return Language.XED;
					case 'g': return Language.XEG;
					case 'l': return Language.XEL;
					case 'm': return Language.XEM;
					case 'p': return Language.XEP;
					case 'r': return Language.XER;
					case 's': return Language.XES;
					case 't': return Language.XET;
					case 'u': return Language.XEU;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_xf(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.XFA;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_xg(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.XGA;
					case 'b': return Language.XGB;
					case 'd': return Language.XGD;
					case 'f': return Language.XGF;
					case 'g': return Language.XGG;
					case 'i': return Language.XGI;
					case 'l': return Language.XGL;
					case 'm': return Language.XGM;
					case 'n': return Language.XGN;
					case 'r': return Language.XGR;
					case 'u': return Language.XGU;
					case 'w': return Language.XGW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_xi(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.ACN;
					case 'b': return Language.XIB;
					case 'i': return Language.XII;
					case 'l': return Language.XIL;
					case 'n': return Language.XIN;
					case 'p': return Language.XIP;
					case 'r': return Language.XIR;
					case 's': return Language.XIS;
					case 'v': return Language.XIV;
					case 'y': return Language.XIY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_xj(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.XJB;
					case 't': return Language.XJT;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_xk(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.XKA;
					case 'b': return Language.XKB;
					case 'c': return Language.XKC;
					case 'd': return Language.XKD;
					case 'e': return Language.XKE;
					case 'f': return Language.XKF;
					case 'g': return Language.XKG;
					case 'h': return Language.WAW;
					case 'i': return Language.XKI;
					case 'j': return Language.XKJ;
					case 'k': return Language.XKK;
					case 'l': return Language.XKL;
					case 'n': return Language.XKN;
					case 'o': return Language.XKO;
					case 'p': return Language.XKP;
					case 'q': return Language.XKQ;
					case 'r': return Language.XKR;
					case 's': return Language.XKS;
					case 't': return Language.XKT;
					case 'u': return Language.XKU;
					case 'v': return Language.XKV;
					case 'w': return Language.XKW;
					case 'x': return Language.XKX;
					case 'y': return Language.XKY;
					case 'z': return Language.XKZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_xl(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.XLA;
					case 'b': return Language.XLB;
					case 'c': return Language.XLC;
					case 'd': return Language.XLD;
					case 'e': return Language.XLE;
					case 'g': return Language.XLG;
					case 'i': return Language.XLI;
					case 'n': return Language.XLN;
					case 'o': return Language.XLO;
					case 'p': return Language.XLP;
					case 's': return Language.XLS;
					case 'u': return Language.XLU;
					case 'y': return Language.XLY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_xm(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.XMA;
					case 'b': return Language.XMB;
					case 'c': return Language.XMC;
					case 'd': return Language.XMD;
					case 'e': return Language.XME;
					case 'f': return Language.XMF;
					case 'g': return Language.XMG;
					case 'h': return Language.XMH;
					case 'j': return Language.XMJ;
					case 'k': return Language.XMK;
					case 'l': return Language.XML;
					case 'm': return Language.XMM;
					case 'n': return Language.XMN;
					case 'o': return Language.XMO;
					case 'p': return Language.XMP;
					case 'q': return Language.XMQ;
					case 'r': return Language.XMR;
					case 's': return Language.XMS;
					case 't': return Language.XMT;
					case 'u': return Language.XMU;
					case 'v': return Language.XMV;
					case 'w': return Language.XMW;
					case 'x': return Language.XMX;
					case 'y': return Language.XMY;
					case 'z': return Language.XMZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_xn(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.XNA;
					case 'b': return Language.XNB;
					case 'd': return Language.XND;
					case 'g': return Language.XNG;
					case 'h': return Language.XNH;
					case 'i': return Language.XNI;
					case 'k': return Language.XNK;
					case 'n': return Language.XNN;
					case 'o': return Language.XNO;
					case 'r': return Language.XNR;
					case 's': return Language.XNS;
					case 't': return Language.XNT;
					case 'u': return Language.XNU;
					case 'y': return Language.XNY;
					case 'z': return Language.XNZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_xo(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'c': return Language.XOC;
					case 'd': return Language.XOD;
					case 'g': return Language.XOG;
					case 'i': return Language.XOI;
					case 'k': return Language.XOK;
					case 'm': return Language.XOM;
					case 'n': return Language.XON;
					case 'o': return Language.XOO;
					case 'p': return Language.XOP;
					case 'r': return Language.XOR;
					case 'w': return Language.XOW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_xp(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.XPA;
					case 'c': return Language.XPC;
					case 'e': return Language.XPE;
					case 'g': return Language.XPG;
					case 'i': return Language.XPI;
					case 'j': return Language.XPJ;
					case 'k': return Language.XPK;
					case 'm': return Language.XPM;
					case 'n': return Language.XPN;
					case 'o': return Language.XPO;
					case 'p': return Language.XPP;
					case 'q': return Language.XPQ;
					case 'r': return Language.XPR;
					case 's': return Language.XPS;
					case 't': return Language.XPT;
					case 'u': return Language.XPU;
					case 'y': return Language.XPY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_xq(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.XQA;
					case 't': return Language.XQT;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_xr(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.XRA;
					case 'b': return Language.XRB;
					case 'd': return Language.XRD;
					case 'e': return Language.XRE;
					case 'g': return Language.XRG;
					case 'i': return Language.XRI;
					case 'm': return Language.XRM;
					case 'n': return Language.XRN;
					case 'q': return Language.XRQ;
					case 'r': return Language.XRR;
					case 't': return Language.XRT;
					case 'u': return Language.XRU;
					case 'w': return Language.XRW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_xs(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.XSA;
					case 'b': return Language.XSB;
					case 'c': return Language.XSC;
					case 'd': return Language.XSD;
					case 'e': return Language.XSE;
					case 'h': return Language.XSH;
					case 'i': return Language.XSI;
					case 'j': return Language.SUJ;
					case 'l': return Language.XSL;
					case 'm': return Language.XSM;
					case 'n': return Language.XSN;
					case 'o': return Language.XSO;
					case 'p': return Language.XSP;
					case 'q': return Language.XSQ;
					case 'r': return Language.XSR;
					case 's': return Language.XSS;
					case 'u': return Language.XSU;
					case 'v': return Language.XSV;
					case 'y': return Language.XSY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_xt(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.XTA;
					case 'b': return Language.XTB;
					case 'c': return Language.XTC;
					case 'd': return Language.XTD;
					case 'e': return Language.XTE;
					case 'g': return Language.XTG;
					case 'h': return Language.XTH;
					case 'i': return Language.XTI;
					case 'j': return Language.XTJ;
					case 'l': return Language.XTL;
					case 'm': return Language.XTM;
					case 'n': return Language.XTN;
					case 'o': return Language.XTO;
					case 'p': return Language.XTP;
					case 'q': return Language.XTQ;
					case 'r': return Language.XTR;
					case 's': return Language.XTS;
					case 't': return Language.XTT;
					case 'u': return Language.XTU;
					case 'v': return Language.XTV;
					case 'w': return Language.XTW;
					case 'y': return Language.XTY;
					case 'z': return Language.XTZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_xu(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.XUA;
					case 'b': return Language.XUB;
					case 'd': return Language.XUD;
					case 'g': return Language.XUG;
					case 'j': return Language.XUJ;
					case 'l': return Language.XUL;
					case 'm': return Language.XUM;
					case 'n': return Language.XUN;
					case 'o': return Language.XUO;
					case 'p': return Language.XUP;
					case 'r': return Language.XUR;
					case 't': return Language.XUT;
					case 'u': return Language.XUU;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_xv(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'e': return Language.XVE;
					case 'i': return Language.XVI;
					case 'n': return Language.XVN;
					case 'o': return Language.XVO;
					case 's': return Language.XVS;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_xw(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.XWA;
					case 'c': return Language.XWC;
					case 'd': return Language.XWD;
					case 'e': return Language.XWE;
					case 'g': return Language.XWG;
					case 'j': return Language.XWJ;
					case 'k': return Language.XWK;
					case 'l': return Language.XWL;
					case 'o': return Language.XWO;
					case 'r': return Language.XWR;
					case 't': return Language.XWT;
					case 'w': return Language.XWW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_xx(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.XXB;
					case 'k': return Language.XXK;
					case 'm': return Language.XXM;
					case 'r': return Language.XXR;
					case 't': return Language.XXT;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_xy(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.XYA;
					case 'b': return Language.XYB;
					case 'j': return Language.XYJ;
					case 'k': return Language.XYK;
					case 'l': return Language.XYL;
					case 't': return Language.XYT;
					case 'y': return Language.XYY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_xz(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'h': return Language.XZH;
					case 'm': return Language.XZM;
					case 'p': return Language.XZP;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_y(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'i': return tryParseFromLanguage_yi(text, ref offset);
					case 'o': return tryParseFromLanguage_yo(text, ref offset);
					case 'a': return tryParseFromLanguage_ya(text, ref offset);
					case 'b': return tryParseFromLanguage_yb(text, ref offset);
					case 'c': return tryParseFromLanguage_yc(text, ref offset);
					case 'd': return tryParseFromLanguage_yd(text, ref offset);
					case 'e': return tryParseFromLanguage_ye(text, ref offset);
					case 'g': return tryParseFromLanguage_yg(text, ref offset);
					case 'h': return tryParseFromLanguage_yh(text, ref offset);
					case 'k': return tryParseFromLanguage_yk(text, ref offset);
					case 'l': return tryParseFromLanguage_yl(text, ref offset);
					case 'm': return tryParseFromLanguage_ym(text, ref offset);
					case 'n': return tryParseFromLanguage_yn(text, ref offset);
					case 'p': return tryParseFromLanguage_yp(text, ref offset);
					case 'r': return tryParseFromLanguage_yr(text, ref offset);
					case 's': return tryParseFromLanguage_ys(text, ref offset);
					case 't': return tryParseFromLanguage_yt(text, ref offset);
					case 'u': return tryParseFromLanguage_yu(text, ref offset);
					case 'v': return tryParseFromLanguage_yv(text, ref offset);
					case 'w': return tryParseFromLanguage_yw(text, ref offset);
					case 'x': return tryParseFromLanguage_yx(text, ref offset);
					case 'y': return tryParseFromLanguage_yy(text, ref offset);
					case 'z': return tryParseFromLanguage_yz(text, ref offset);
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_yi(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.YIA;
					case 'f': return Language.YIF;
					case 'g': return Language.YIG;
					case 'h': return Language.YIH;
					case 'i': return Language.YII;
					case 'j': return Language.YIJ;
					case 'k': return Language.YIK;
					case 'l': return Language.YIL;
					case 'm': return Language.YIM;
					case 'n': return Language.YIN;
					case 'p': return Language.YIP;
					case 'q': return Language.YIQ;
					case 'r': return Language.YIR;
					case 's': return Language.YIS;
					case 't': return Language.YIT;
					case 'u': return Language.YIU;
					case 'v': return Language.YIV;
					case 'x': return Language.YIX;
					case 'y': return Language.YIY;
					case 'z': return Language.YIZ;
				}
				offset--;
			}
			return Language.YI;
		}

		private static Language? tryParseFromLanguage_yo(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.YOB;
					case 'g': return Language.YOG;
					case 'i': return Language.YOI;
					case 'k': return Language.YOK;
					case 'l': return Language.YOL;
					case 'm': return Language.YOM;
					case 'n': return Language.YON;
					case 's': return Language.ZOM;
					case 't': return Language.YOT;
					case 'x': return Language.YOX;
					case 'y': return Language.YOY;
				}
				offset--;
			}
			return Language.YO;
		}

		private static Language? tryParseFromLanguage_ya(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.YAA;
					case 'b': return Language.YAB;
					case 'c': return Language.YAC;
					case 'd': return Language.YAD;
					case 'e': return Language.YAE;
					case 'f': return Language.YAF;
					case 'g': return Language.YAG;
					case 'h': return Language.YAH;
					case 'i': return Language.YAI;
					case 'j': return Language.YAJ;
					case 'k': return Language.YAK;
					case 'l': return Language.YAL;
					case 'm': return Language.YAM;
					case 'n': return Language.YAN;
					case 'o': return Language.YAO;
					case 'p': return Language.YAP;
					case 'q': return Language.YAQ;
					case 'r': return Language.YAR;
					case 's': return Language.YAS;
					case 't': return Language.YAT;
					case 'u': return Language.YAU;
					case 'v': return Language.YAV;
					case 'w': return Language.YAW;
					case 'x': return Language.YAX;
					case 'y': return Language.YAY;
					case 'z': return Language.YAZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_yb(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.YBA;
					case 'b': return Language.YBB;
					case 'd': return Language.RKI;
					case 'e': return Language.YBE;
					case 'h': return Language.YBH;
					case 'i': return Language.YBI;
					case 'j': return Language.YBJ;
					case 'k': return Language.YBK;
					case 'l': return Language.YBL;
					case 'm': return Language.YBM;
					case 'n': return Language.YBN;
					case 'o': return Language.YBO;
					case 'x': return Language.YBX;
					case 'y': return Language.YBY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_yc(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'h': return Language.YCH;
					case 'l': return Language.YCL;
					case 'n': return Language.YCN;
					case 'p': return Language.YCP;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_yd(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.YDA;
					case 'd': return Language.YDD;
					case 'e': return Language.YDE;
					case 'g': return Language.YDG;
					case 'k': return Language.YDK;
					case 's': return Language.YDS;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ye(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.YEA;
					case 'c': return Language.YEC;
					case 'e': return Language.YEE;
					case 'i': return Language.YEI;
					case 'j': return Language.YEJ;
					case 'l': return Language.YEL;
					case 'n': return Language.YEN;
					case 'r': return Language.YER;
					case 's': return Language.YES;
					case 't': return Language.YET;
					case 'u': return Language.YEU;
					case 'v': return Language.YEV;
					case 'y': return Language.YEY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_yg(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.YGA;
					case 'i': return Language.YGI;
					case 'l': return Language.YGL;
					case 'm': return Language.YGM;
					case 'p': return Language.YGP;
					case 'r': return Language.YGR;
					case 's': return Language.YGS;
					case 'u': return Language.YGU;
					case 'w': return Language.YGW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_yh(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.YHA;
					case 'd': return Language.YHD;
					case 'l': return Language.YHL;
					case 's': return Language.YHS;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_yk(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.YKA;
					case 'g': return Language.YKG;
					case 'i': return Language.YKI;
					case 'k': return Language.YKK;
					case 'l': return Language.YKL;
					case 'm': return Language.YKM;
					case 'n': return Language.YKN;
					case 'o': return Language.YKO;
					case 'r': return Language.YKR;
					case 't': return Language.YKT;
					case 'u': return Language.YKU;
					case 'y': return Language.YKY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_yl(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.YLA;
					case 'b': return Language.YLB;
					case 'e': return Language.YLE;
					case 'g': return Language.YLG;
					case 'i': return Language.YLI;
					case 'l': return Language.YLL;
					case 'm': return Language.YLM;
					case 'n': return Language.YLN;
					case 'o': return Language.YLO;
					case 'r': return Language.YLR;
					case 'u': return Language.YLU;
					case 'y': return Language.YLY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ym(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.LRR;
					case 'b': return Language.YMB;
					case 'c': return Language.YMC;
					case 'd': return Language.YMD;
					case 'e': return Language.YME;
					case 'g': return Language.YMG;
					case 'h': return Language.YMH;
					case 'i': return Language.YMI;
					case 'k': return Language.YMK;
					case 'l': return Language.YML;
					case 'm': return Language.YMM;
					case 'n': return Language.YMN;
					case 'o': return Language.YMO;
					case 'p': return Language.YMP;
					case 'q': return Language.YMQ;
					case 'r': return Language.YMR;
					case 's': return Language.YMS;
					case 't': return Language.MTM;
					case 'x': return Language.YMX;
					case 'z': return Language.YMZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_yn(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.YNA;
					case 'd': return Language.YND;
					case 'e': return Language.YNE;
					case 'g': return Language.YNG;
					case 'h': return Language.YNH;
					case 'k': return Language.YNK;
					case 'l': return Language.YNL;
					case 'n': return Language.YNN;
					case 'o': return Language.YNO;
					case 'q': return Language.YNQ;
					case 's': return Language.YNS;
					case 'u': return Language.YNU;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_yp(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.YPA;
					case 'b': return Language.YPB;
					case 'g': return Language.YPG;
					case 'h': return Language.YPH;
					case 'k': return Language.YPK;
					case 'm': return Language.YPM;
					case 'n': return Language.YPN;
					case 'o': return Language.YPO;
					case 'p': return Language.YPP;
					case 'z': return Language.YPZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_yr(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.YRA;
					case 'b': return Language.YRB;
					case 'e': return Language.YRE;
					case 'i': return Language.YRI;
					case 'k': return Language.YRK;
					case 'l': return Language.YRL;
					case 'm': return Language.YRM;
					case 'n': return Language.YRN;
					case 'o': return Language.YRO;
					case 's': return Language.YRS;
					case 'w': return Language.YRW;
					case 'y': return Language.YRY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ys(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'c': return Language.YSC;
					case 'd': return Language.YSD;
					case 'g': return Language.YSG;
					case 'l': return Language.YSL;
					case 'n': return Language.YSN;
					case 'o': return Language.YSO;
					case 'p': return Language.YSP;
					case 'r': return Language.YSR;
					case 's': return Language.YSS;
					case 'y': return Language.YSY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_yt(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.YTA;
					case 'l': return Language.YTL;
					case 'p': return Language.YTP;
					case 'w': return Language.YTW;
					case 'y': return Language.YTY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_yu(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.YUA;
					case 'b': return Language.YUB;
					case 'c': return Language.YUC;
					case 'd': return Language.YUD;
					case 'e': return Language.YUE;
					case 'f': return Language.YUF;
					case 'g': return Language.YUG;
					case 'i': return Language.YUI;
					case 'j': return Language.YUJ;
					case 'k': return Language.YUK;
					case 'l': return Language.YUL;
					case 'm': return Language.YUM;
					case 'n': return Language.YUN;
					case 'p': return Language.YUP;
					case 'q': return Language.YUQ;
					case 'r': return Language.YUR;
					case 't': return Language.YUT;
					case 'u': return Language.YUG;
					case 'w': return Language.YUW;
					case 'x': return Language.YUX;
					case 'y': return Language.YUY;
					case 'z': return Language.YUZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_yv(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.YVA;
					case 't': return Language.YVT;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_yw(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.YWA;
					case 'g': return Language.YWG;
					case 'l': return Language.YWL;
					case 'n': return Language.YWN;
					case 'q': return Language.YWQ;
					case 'r': return Language.YWR;
					case 't': return Language.YWT;
					case 'u': return Language.YWU;
					case 'w': return Language.YWW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_yx(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.YXA;
					case 'g': return Language.YXG;
					case 'l': return Language.YXL;
					case 'm': return Language.YXM;
					case 'u': return Language.YXU;
					case 'y': return Language.YXY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_yy(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'r': return Language.YYR;
					case 'u': return Language.YYU;
					case 'z': return Language.YYZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_yz(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'g': return Language.YZG;
					case 'k': return Language.YZK;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_z(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return tryParseFromLanguage_za(text, ref offset);
					case 'h': return tryParseFromLanguage_zh(text, ref offset);
					case 'u': return tryParseFromLanguage_zu(text, ref offset);
					case 'b': return tryParseFromLanguage_zb(text, ref offset);
					case 'c': return tryParseFromLanguage_zc(text, ref offset);
					case 'd': return tryParseFromLanguage_zd(text, ref offset);
					case 'e': return tryParseFromLanguage_ze(text, ref offset);
					case 'g': return tryParseFromLanguage_zg(text, ref offset);
					case 'i': return tryParseFromLanguage_zi(text, ref offset);
					case 'k': return tryParseFromLanguage_zk(text, ref offset);
					case 'l': return tryParseFromLanguage_zl(text, ref offset);
					case 'm': return tryParseFromLanguage_zm(text, ref offset);
					case 'n': return tryParseFromLanguage_zn(text, ref offset);
					case 'o': return tryParseFromLanguage_zo(text, ref offset);
					case 'p': return tryParseFromLanguage_zp(text, ref offset);
					case 'q': return tryParseFromLanguage_zq(text, ref offset);
					case 'r': return tryParseFromLanguage_zr(text, ref offset);
					case 's': return tryParseFromLanguage_zs(text, ref offset);
					case 't': return tryParseFromLanguage_zt(text, ref offset);
					case 'w': return tryParseFromLanguage_zw(text, ref offset);
					case 'x': return tryParseFromLanguage_zx(text, ref offset);
					case 'y': return tryParseFromLanguage_zy(text, ref offset);
					case 'z': return tryParseFromLanguage_zz(text, ref offset);
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_za(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.ZAA;
					case 'b': return Language.ZAB;
					case 'c': return Language.ZAC;
					case 'd': return Language.ZAD;
					case 'e': return Language.ZAE;
					case 'f': return Language.ZAF;
					case 'g': return Language.ZAG;
					case 'h': return Language.ZAH;
					case 'i': return Language.ZAI;
					case 'j': return Language.ZAJ;
					case 'k': return Language.ZAK;
					case 'l': return Language.ZAL;
					case 'm': return Language.ZAM;
					case 'o': return Language.ZAO;
					case 'p': return Language.ZAP;
					case 'q': return Language.ZAQ;
					case 'r': return Language.ZAR;
					case 's': return Language.ZAS;
					case 't': return Language.ZAT;
					case 'u': return Language.ZAU;
					case 'v': return Language.ZAV;
					case 'w': return Language.ZAW;
					case 'x': return Language.ZAX;
					case 'y': return Language.ZAY;
					case 'z': return Language.ZAZ;
				}
				offset--;
			}
			return Language.ZA;
		}

		private static Language? tryParseFromLanguage_zh(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.ZHB;
					case 'd': return Language.ZHD;
					case 'i': return Language.ZHI;
					case 'n': return Language.ZHN;
					case 'w': return Language.ZHW;
					case 'x': return Language.ZHX;
				}
				offset--;
			}
			return Language.ZH;
		}

		private static Language? tryParseFromLanguage_zu(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.ZUA;
					case 'h': return Language.ZUH;
					case 'm': return Language.ZUM;
					case 'n': return Language.ZUN;
					case 'y': return Language.ZUY;
				}
				offset--;
			}
			return Language.ZU;
		}

		private static Language? tryParseFromLanguage_zb(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'c': return Language.ZBC;
					case 'e': return Language.ZBE;
					case 'l': return Language.ZBL;
					case 't': return Language.ZBT;
					case 'w': return Language.ZBW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_zc(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.ZCA;
					case 'h': return Language.ZCH;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_zd(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'j': return Language.ZDJ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_ze(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.ZEA;
					case 'g': return Language.ZEG;
					case 'h': return Language.ZEH;
					case 'n': return Language.ZEN;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_zg(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.ZGA;
					case 'b': return Language.ZGB;
					case 'h': return Language.ZGH;
					case 'm': return Language.ZGM;
					case 'n': return Language.ZGN;
					case 'r': return Language.ZGR;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_zi(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.ZIA;
					case 'b': return Language.ZIB;
					case 'k': return Language.ZIK;
					case 'l': return Language.ZIL;
					case 'm': return Language.ZIM;
					case 'n': return Language.ZIN;
					case 'r': return Language.ZIR;
					case 'w': return Language.ZIW;
					case 'z': return Language.ZIZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_zk(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.ZKA;
					case 'b': return Language.ZKB;
					case 'd': return Language.ZKD;
					case 'g': return Language.ZKG;
					case 'h': return Language.ZKH;
					case 'k': return Language.ZKK;
					case 'n': return Language.ZKN;
					case 'o': return Language.ZKO;
					case 'p': return Language.ZKP;
					case 'r': return Language.ZKR;
					case 't': return Language.ZKT;
					case 'u': return Language.ZKU;
					case 'v': return Language.ZKV;
					case 'z': return Language.ZKZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_zl(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'e': return Language.ZLE;
					case 'j': return Language.ZLJ;
					case 'm': return Language.ZLM;
					case 'n': return Language.ZLN;
					case 'q': return Language.ZLQ;
					case 's': return Language.ZLS;
					case 'w': return Language.ZLW;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_zm(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.ZMA;
					case 'b': return Language.ZMB;
					case 'c': return Language.ZMC;
					case 'd': return Language.ZMD;
					case 'e': return Language.ZME;
					case 'f': return Language.ZMF;
					case 'g': return Language.ZMG;
					case 'h': return Language.ZMH;
					case 'i': return Language.ZMI;
					case 'j': return Language.ZMJ;
					case 'k': return Language.ZMK;
					case 'l': return Language.ZML;
					case 'm': return Language.ZMM;
					case 'n': return Language.ZMN;
					case 'o': return Language.ZMO;
					case 'p': return Language.ZMP;
					case 'q': return Language.ZMQ;
					case 'r': return Language.ZMR;
					case 's': return Language.ZMS;
					case 't': return Language.ZMT;
					case 'u': return Language.ZMU;
					case 'v': return Language.ZMV;
					case 'w': return Language.ZMW;
					case 'x': return Language.ZMX;
					case 'y': return Language.ZMY;
					case 'z': return Language.ZMZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_zn(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.ZNA;
					case 'd': return Language.ZND;
					case 'e': return Language.ZNE;
					case 'g': return Language.ZNG;
					case 'k': return Language.ZNK;
					case 's': return Language.ZNS;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_zo(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'c': return Language.ZOC;
					case 'h': return Language.ZOH;
					case 'm': return Language.ZOM;
					case 'o': return Language.ZOO;
					case 'q': return Language.ZOQ;
					case 'r': return Language.ZOR;
					case 's': return Language.ZOS;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_zp(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.ZPA;
					case 'b': return Language.ZPB;
					case 'c': return Language.ZPC;
					case 'd': return Language.ZPD;
					case 'e': return Language.ZPE;
					case 'f': return Language.ZPF;
					case 'g': return Language.ZPG;
					case 'h': return Language.ZPH;
					case 'i': return Language.ZPI;
					case 'j': return Language.ZPJ;
					case 'k': return Language.ZPK;
					case 'l': return Language.ZPL;
					case 'm': return Language.ZPM;
					case 'n': return Language.ZPN;
					case 'o': return Language.ZPO;
					case 'p': return Language.ZPP;
					case 'q': return Language.ZPQ;
					case 'r': return Language.ZPR;
					case 's': return Language.ZPS;
					case 't': return Language.ZPT;
					case 'u': return Language.ZPU;
					case 'v': return Language.ZPV;
					case 'w': return Language.ZPW;
					case 'x': return Language.ZPX;
					case 'y': return Language.ZPY;
					case 'z': return Language.ZPZ;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_zq(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'e': return Language.ZQE;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_zr(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.ZRA;
					case 'g': return Language.ZRG;
					case 'n': return Language.ZRN;
					case 'o': return Language.ZRO;
					case 'p': return Language.ZRP;
					case 's': return Language.ZRS;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_zs(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.ZSA;
					case 'k': return Language.ZSK;
					case 'l': return Language.ZSL;
					case 'm': return Language.ZSM;
					case 'r': return Language.ZSR;
					case 'u': return Language.ZSU;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_zt(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'e': return Language.ZTE;
					case 'g': return Language.ZTG;
					case 'l': return Language.ZTL;
					case 'm': return Language.ZTM;
					case 'n': return Language.ZTN;
					case 'p': return Language.ZTP;
					case 'q': return Language.ZTQ;
					case 's': return Language.ZTS;
					case 't': return Language.ZTT;
					case 'u': return Language.ZTU;
					case 'x': return Language.ZTX;
					case 'y': return Language.ZTY;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_zw(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.ZWA;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_zx(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'x': return Language.ZXX;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_zy(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'b': return Language.ZYB;
					case 'g': return Language.ZYG;
					case 'j': return Language.ZYJ;
					case 'n': return Language.ZYN;
					case 'p': return Language.ZYP;
				}
				offset--;
			}
			return null;
		}

		private static Language? tryParseFromLanguage_zz(string text, ref int offset)
		{
			if(offset < text.Length)
			{
				var ch = Char.ToLowerInvariant(text[offset]);
				offset++;
				switch(ch)
				{
					case 'a': return Language.ZZA;
					case 'j': return Language.ZZJ;
				}
				offset--;
			}
			return null;
		}
	}
}
