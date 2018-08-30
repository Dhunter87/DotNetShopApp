
using System;
namespace SelfTrainingProject.DotNetShop
{
	public class ProductList
	{
		public ProductList()
		{/*
			string[,,] ProductList =
			{
				{"mens/trainers/white/NIKE", "MK1N", "1"}, 
				{"mens/trainers/white/ADDIDAS", "MK1A", "2"},
				{"mens/trainers/white/PUMA", "MK1P","3"}, 
				{"mens/trainers/white/CONVERSE", "MK1C","4"},
				{"mens/trainers/white/LONSDALE", "MK1L","5"},

				{"mens/trainers/black/NIKE", "MK2N","6"},
				{"mens/trainers/black/ADDIDAS", "MK2A","7"},
				{"mens/trainers/black/PUMA", "MK2P","8"},
				{"mens/trainers/black/CONVERSE", "MK2C","9"}, 
				{"mens/trainers/white/LONSDALE", "MK2L","10"},

				{"mens/trainers/blue/NIKE", "MK3N","11"}, 
				{"mens/trainers/blue/ADDIDAS", "MK3A","12"},
				{"mens/trainers/blue/PUMA", "MK3P","13"}, 
				{"mens/trainers/blue/CONVERSE", "MK3C","14"},
				{"mens/trainers/blue/LONSDALE", "MK3L","15"},

				{"mens/trainers/red/NIKE", "MK4N","16"},
				{"mens/trainers/red/ADDIDAS", "MK4A","17"},
				{"mens/trainers/red/PUMA", "MK4P","18"},
				{"mens/trainers/red/CONVERSE", "MK4C","19"},
				{"mens/trainers/red/LONSDALE", "MK4L","20"},

				{"mens/trainers/green/NIKE", "MK5N","21"}, 
                {"mens/trainers/green/ADDIDAS", "MK5A","22"},
				{"mens/trainers/green/PUMA", "MK5P","23"}, 
				{"mens/trainers/green/CONVERSE", "MK5C","24"},
				{"mens/trainers/green/LONSDALE", "MK5L","25"},


				{"mens/t-shirts/white/NIKE", "MT1N","26"}, 
				{"mens/t-shirts/white/ADDIDAS", "MT1A","27"},
				{"mens/t-shirts/white/PUMA", "MT1P","28"}, 
				{"mens/t-shirts/white/CONVERSE", "MT1C","29"},
				{"mens/t-shirts/white/LONSDALE", "MT1L","30"},

				{"mens/t-shirts/black/NIKE", "MT2N","31"},
				{"mens/t-shirts/black/ADDIDAS", "MT2A","32"},
				{"mens/t-shirts/black/PUMA", "MT2P","33"},
				{"mens/t-shirts/black/CONVERSE", "MT2C","34"}, 
				{"mens/t-shirts/white/LONSDALE", "MT2L","35"},

				{"mens/t-shirts/blue/NIKE", "MT3N","36"}, 
				{"mens/t-shirts/blue/ADDIDAS", "MT3A","37"},
				{"mens/t-shirts/blue/PUMA", "MT3P","38"}, 
				{"mens/t-shirts/blue/CONVERSE", "MT3C","39"},
				{"mens/t-shirts/blue/LONSDALE", "MT3L","40"},

				{"mens/t-shirts/red/NIKE", "MT4N","41"},
				{"mens/t-shirts/red/ADDIDAS", "MT4A","42"},
				{"mens/t-shirts/red/PUMA", "MT4P","43"},
				{"mens/t-shirts/red/CONVERSE", "MT4C","44"}, 
				{"mens/t-shirts/red/LONSDALE", "MT4L","45"},

				{"mens/t-shirts/green/NIKE", "MT5N","46"}, 
				{"mens/t-shirts/green/ADDIDAS", "MT5A","47"},
				{"mens/t-shirts/green/PUMA", "MT5P","48"}, 
				{"mens/t-shirts/green/CONVERSE", "MT5C","49"},
				{"mens/t-shirts/green/LONSDALE", "MT5L","50"},


				{"mens/shorts/white/NIKE", "MS1N","51"}, 
				{"mens/shorts/white/ADDIDAS", "MS1A","52"},
				{"mens/shorts/white/PUMA", "MS1P","53"}, 
				{"mens/shorts/white/CONVERSE", "MS1C","54"},
				{"mens/shorts/white/LONSDALE", "MS1L","55"},

				{"mens/shorts/black/NIKE", "MS2N","56"},
				{"mens/shorts/black/ADDIDAS", "MS2A","57"},
				{"mens/shorts/black/PUMA", "MS2P","58"},
				{"mens/shorts/black/CONVERSE", "MS2C","59"},
				{"mens/shorts/white/LONSDALE", "MS2L","60"},

				{"mens/shorts/blue/NIKE", "MS3N","61"}, 
				{"mens/shorts/blue/ADDIDAS", "MS3A","62"},
				{"mens/shorts/blue/PUMA", "MS3P","63"}, 
				{"mens/shorts/blue/CONVERSE", "MS3C","64"},
				{"mens/shorts/blue/LONSDALE", "MS3L","65"},

				{"mens/shorts/red/NIKE", "MS4N","66"},
				{"mens/shorts/red/ADDIDAS", "MS4A","67"},
				{"mens/shorts/red/PUMA", "MS4P","68"},
				{"mens/shorts/red/CONVERSE", "MS4C","69"},
				{"mens/shorts/red/LONSDALE", "MS4L","70"},

				{"mens/shorts/green/NIKE", "MS5N","71"}, 
				{"mens/shorts/green/ADDIDAS", "MS5A","72"},
				{"mens/shorts/green/PUMA", "MS5P","73"}, 
				{"mens/shorts/green/CONVERSE", "MS5C","74"},
				{"mens/shorts/green/LONSDALE", "MS5L","75"},


				{"mens/tracksuit bottoms/white/NIKE", "MB1N","76"}, 
				{"mens/tracksuit bottoms/white/ADDIDAS", "MB1A","77"},
				{"mens/tracksuit bottoms/white/PUMA", "MB1P","78"}, 
				{"mens/tracksuit bottoms/white/CONVERSE", "MB1C","79"},
				{"mens/tracksuit bottoms/white/LONSDALE", "MB1L","80"},

				{"mens/tracksuit bottoms/black/NIKE", "MB2N","81"},
				{"mens/tracksuit bottoms/black/ADDIDAS", "MB2A","82"},
				{"mens/tracksuit bottoms/black/PUMA", "MB2P","83"},
				{"mens/tracksuit bottoms/black/CONVERSE", "MB2C","84"}, 
				{"mens/tracksuit bottoms/white/LONSDALE", "MB2L","85"},

				{"mens/tracksuit bottoms/blue/NIKE", "MB3N","86"},
				{"mens/tracksuit bottoms/blue/ADDIDAS", "MB3A","87"},
				{"mens/tracksuit bottoms/blue/PUMA", "MB3P","88"}, 
				{"mens/tracksuit bottoms/blue/CONVERSE", "MB3C","89"},
				{"mens/tracksuit bottoms/blue/LONSDALE", "MB3L","90"},

				{"mens/tracksuit bottoms/red/NIKE", "MB4N","91"},
				{"mens/tracksuit bottoms/red/ADDIDAS", "MB4A","92"},
				{"mens/tracksuit bottoms/red/PUMA", "MB4P","93"},
				{"mens/tracksuit bottoms/red/CONVERSE", "MB4C","94"}, 
				{"mens/tracksuit bottoms/red/LONSDALE", "MB4L","95"},

				{"mens/tracksuit bottoms/green/NIKE", "MB5N","96"}, 
				{"mens/tracksuit bottoms/green/ADDIDAS", "MB5A","97"},
				{"mens/tracksuit bottoms/green/PUMA", "MB5P","98"},
				{"mens/tracksuit bottoms/green/CONVERSE", "MB5C","99"},
				{"mens/tracksuit bottoms/green/LONSDALE", "MB5L","100"},


				{"mens/hoodies/white/NIKE", "MH1N","101"}, 
				{"mens/hoodies/white/ADDIDAS", "MH1A","102"},
				{"mens/hoodies/white/PUMA", "MH1P","103"}, 
				{"mens/hoodies/white/CONVERSE", "MH1C","104"},
				{"mens/hoodies/white/LONSDALE", "MH1L","105"},

				{"mens/hoodies/black/NIKE", "MH2N","106"},
				{"mens/hoodies/black/ADDIDAS", "MH2A","107"},
				{"mens/hoodies/black/PUMA", "MH2P","108"},
				{"mens/hoodies/black/CONVERSE", "MH2C","109"}, 
				{"mens/hoodies/white/LONSDALE", "MH2L","110"},

				{"mens/hoodies/blue/NIKE", "MH3N","111"}, 
				{"mens/hoodies/blue/ADDIDAS", "MH3A","112"},
				{"mens/hoodies/blue/PUMA", "MH3P","113"}, 
				{"mens/hoodies/blue/CONVERSE", "MH3C","114"},
				{"mens/hoodies/blue/LONSDALE", "MH3L","115"},

				{"mens/hoodies/red/NIKE", "MH4N","116"},
				{"mens/hoodies/red/ADDIDAS", "MH4A","117"},
				{"mens/hoodies/red/PUMA", "MH4P","118"},
				{"mens/hoodies/red/CONVERSE", "MH4C","119"}, 
				{"mens/hoodies/red/LONSDALE", "MH4L","120"},

				{"mens/hoodies/green/NIKE", "MH5N","121"}, 
				{"mens/hoodies/green/ADDIDAS", "MH5A","122"},
				{"mens/hoodies/green/PUMA", "MH5P","123"}, 
				{"mens/hoodies/green/CONVERSE", "MH5C","124"},
				{"mens/hoodies/green/LONSDALE", "MH5L","125"},


				{"womens/trainers/white/NIKE", "WK1N","126"}, 
				{ "womens/trainers/white/ADDIDAS", "WK1A","127"},
				{ "womens/trainers/white/PUMA", "WK1P","128"},
				{ "womens/trainers/white/CONVERSE", "WK1C","129"},
				{ "womens/trainers/white/LONSDALE", "WK1L","130"},

				{ "womens/trainers/black/NIKE", "WK2N","131"},
				{ "womens/trainers/black/ADDIDAS", "WK2A","132"},
				{ "womens/trainers/black/PUMA", "WK2P","133"},
				{ "womens/trainers/black/CONVERSE", "WK2C","134"},
				{ "womens/trainers/white/LONSDALE", "WK2L","135"},

				{ "womens/trainers/blue/NIKE", "WK3N","136"}, 
				{ "womens/trainers/blue/ADDIDAS", "WK3A","137"},
				{ "womens/trainers/blue/PUMA", "WK3P","138"}, 
				{ "womens/trainers/blue/CONVERSE", "WK3C","139"},
				{ "womens/trainers/blue/LONSDALE", "WK3L","140"},

				{ "womens/trainers/red/NIKE", "WK4N","141"},
				{ "womens/trainers/red/ADDIDAS", "WK4A","142"},
				{ "womens/trainers/red/PUMA", "WK4P","143"},
				{ "womens/trainers/red/CONVERSE", "WK4C","144"}, 
				{ "womens/trainers/red/LONSDALE", "WK4L","145"},

				{ "womens/trainers/green/NIKE", "WK5N","146"},
				{ "womens/trainers/green/ADDIDAS", "WK5A","147"},
				{ "womens/trainers/green/PUMA", "WK5P","148"}, 
				{ "womens/trainers/green/CONVERSE", "WK5C","149"},
				{ "womens/trainers/green/LONSDALE", "WK5L","150"},


				{ "womens/t-shirts/white/NIKE", "WT1N","151"}, 
				{ "womens/t-shirts/white/ADDIDAS", "WT1A","152"},
				{ "womens/t-shirts/white/PUMA", "WT1P","153"}, 
				{ "womens/t-shirts/white/CONVERSE", "WT1C","154"},
				{ "womens/t-shirts/white/LONSDALE", "WT1L","155"},

				{ "womens/t-shirts/black/NIKE", "WT2N","156"},
				{ "womens/t-shirts/black/ADDIDAS", "WT2A","157"},
				{ "womens/t-shirts/black/PUMA", "WT2P","158"},
				{ "womens/t-shirts/black/CONVERSE", "WT2C","159"}, 
				{ "womens/t-shirts/white/LONSDALE", "WT2L","160"},

				{ "womens/t-shirts/blue/NIKE", "WT3N","161"}, 
				{ "womens/t-shirts/blue/ADDIDAS", "WT3A","162"},
				{ "womens/t-shirts/blue/PUMA", "WT3P","163"},
				{ "womens/t-shirts/blue/CONVERSE", "WT3C","164"},
				{ "womens/t-shirts/blue/LONSDALE", "WT3L","165"},

				{ "womens/t-shirts/red/NIKE", "WT4N","166"},
				{ "womens/t-shirts/red/ADDIDAS", "WT4A","167"},
				{ "womens/t-shirts/red/PUMA", "WT4P","168"},
				{ "womens/t-shirts/red/CONVERSE", "WT4C","169"}, 
				{ "womens/t-shirts/red/LONSDALE", "WT4L","170"},

				{ "womens/t-shirts/green/NIKE", "WT5N","171"},
				{ "womens/t-shirts/green/ADDIDAS", "WT5A","172"},
				{ "womens/t-shirts/green/PUMA", "WT5P","173"}, 
				{ "womens/t-shirts/green/CONVERSE", "WT5C","174"},
				{ "womens/t-shirts/green/LONSDALE", "WT5L","175"},


				{ "womens/shorts/white/NIKE", "WS1N","176"}, 
				{ "womens/shorts/white/ADDIDAS", "MS1A","177"},
				{ "womens/shorts/white/PUMA", "WS1P","178"},
				{ "womens/shorts/white/CONVERSE", "MS1C","179"},
				{ "womens/shorts/white/LONSDALE", "WS1L","180"},

				{ "womens/shorts/black/NIKE", "MS2N","181"},
				{ "womens/shorts/black/ADDIDAS", "WS2A","182"},
				{ "womens/shorts/black/PUMA", "MS2P","183"},
				{ "womens/shorts/black/CONVERSE", "WS2C","184"}, 
				{ "womens/shorts/white/LONSDALE", "MS2L","185"},

				{ "womens/shorts/blue/NIKE", "WS3N","186"}, 
				{ "womens/shorts/blue/ADDIDAS", "MS3A","187"},
				{ "womens/shorts/blue/PUMA", "WS3P","188"}, 
				{ "womens/shorts/blue/CONVERSE", "MS3C","189"},
				{ "womens/shorts/blue/LONSDALE", "WS3L","190"},

				{ "womens/shorts/red/NIKE", "MS4N","191"},
				{ "womens/shorts/red/ADDIDAS", "WS4A","192"},
				{ "womens/shorts/red/PUMA", "MS4P","193"},
				{ "womens/shorts/red/CONVERSE", "WS4C","194"},
				{ "womens/shorts/red/LONSDALE", "MS4L","195"},

				{ "womens/shorts/green/NIKE", "WS5N","196"},
				{ "womens/shorts/green/ADDIDAS", "MS5A","197"},
				{ "womens/shorts/green/PUMA", "WS5P","198"}, 
				{ "womens/shorts/green/CONVERSE", "MS5C","199"},
				{ "womens/shorts/green/LONSDALE", "WS5L","200"},


				{ "womens/tracksuit bottoms/white/NIKE", "WB1N","201"}, 
				{ "womens/tracksuit bottoms/white/ADDIDAS", "MB1A","202"},
				{ "womens/tracksuit bottoms/white/PUMA", "WB1P","203"}, 
				{ "womens/tracksuit bottoms/white/CONVERSE", "MB1C","204"},
				{ "womens/tracksuit bottoms/white/LONSDALE", "WB1L","205"},

				{ "womens/tracksuit bottoms/black/NIKE", "MB2N","206"},
				{ "womens/tracksuit bottoms/black/ADDIDAS", "WB2A","207"},
				{ "womens/tracksuit bottoms/black/PUMA", "MB2P","208"},
				{ "womens/tracksuit bottoms/black/CONVERSE", "WB2C","209"}, 
				{ "womens/tracksuit bottoms/white/LONSDALE", "MB2L","210"},

				{ "womens/tracksuit bottoms/blue/NIKE", "WB3N","211"}, 
				{ "womens/tracksuit bottoms/blue/ADDIDAS", "MB3A","212"},
				{ "womens/tracksuit bottoms/blue/PUMA", "WB3P","213"}, 
				{ "womens/tracksuit bottoms/blue/CONVERSE", "MB3C","214"},
				{ "womens/tracksuit bottoms/blue/LONSDALE", "WB3L","215"},

				{ "womens/tracksuit bottoms/red/NIKE", "MB4N","216"},
				{ "womens/tracksuit bottoms/red/ADDIDAS", "WB4A","217"},
				{ "womens/tracksuit bottoms/red/PUMA", "MB4P","218"},
				{ "womens/tracksuit bottoms/red/CONVERSE", "WB4C","219"}, 
				{ "womens/tracksuit bottoms/red/LONSDALE", "MB4L","220"},

				{ "womens/tracksuit bottoms/green/NIKE", "WB5N","221"}, 
				{ "womens/tracksuit bottoms/green/ADDIDAS", "MB5A","222"},
				{ "womens/tracksuit bottoms/green/PUMA", "WB5P","223"}, 
				{ "womens/tracksuit bottoms/green/CONVERSE", "MB5C","224"},
				{ "womens/tracksuit bottoms/green/LONSDALE", "WB5L","225"},

				{ "womens/hoodies/white/NIKE", "WH1N","226"}, 
				{ "womens/hoodies/white/ADDIDAS", "MH1A","227"},
				{ "womens/hoodies/white/PUMA", "WH1P","228"}, 
				{ "womens/hoodies/white/CONVERSE", "MH1C","229"},
				{ "womens/hoodies/white/LONSDALE", "WH1L","230"},

				{ "womens/hoodies/black/NIKE", "MH2N","231"},
				{ "womens/hoodies/black/ADDIDAS", "WH2A","232"},
				{ "womens/hoodies/black/PUMA", "MH2P","233"},
				{ "womens/hoodies/black/CONVERSE", "WH2C","234"}, 
				{ "womens/hoodies/white/LONSDALE", "MH2L","235"},

				{ "womens/hoodies/blue/NIKE", "WH3N","236"}, 
				{ "womens/hoodies/blue/ADDIDAS", "MH3A","237"},
				{ "womens/hoodies/blue/PUMA", "WH3P","238"}, 
				{ "womens/hoodies/blue/CONVERSE", "MH3C","239"},
				{ "womens/hoodies/blue/LONSDALE", "WH3L","240"},

				{ "womens/hoodies/red/NIKE", "MH4N","241"},
				{ "womens/hoodies/red/ADDIDAS", "WH4A","242"},
				{ "womens/hoodies/red/PUMA", "MH4P","243"},
				{ "womens/hoodies/red/CONVERSE", "WH4C","244"}, 
				{ "womens/hoodies/red/LONSDALE", "MH4L","245"},

				{ "womens/hoodies/green/NIKE", "WH5N","246"}, 
				{ "womens/hoodies/green/ADDIDAS", "MH5A","247"},
				{ "womens/hoodies/green/PUMA", "WH5P","248"}, 
				{ "womens/hoodies/green/CONVERSE", "MH5C","249"},
				{ "womens/hoodies/green/LONSDALE", "WH5L","250"}
			};*/
			}

	}
}