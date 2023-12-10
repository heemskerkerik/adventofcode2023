using System.Collections;
using System.Diagnostics;
using Sprache;
using MoreLinq;

// const string input =
//     "RL\n\nAAA = (BBB, CCC)\nBBB = (DDD, EEE)\nCCC = (ZZZ, GGG)\nDDD = (DDD, DDD)\nEEE = (EEE, EEE)\nGGG = (GGG, GGG)\nZZZ = (ZZZ, ZZZ)\n";
// const string input =
//     "LR\n\n11A = (11B, XXX)\n11B = (XXX, 11Z)\n11Z = (11B, XXX)\n22A = (22B, XXX)\n22B = (22C, 22C)\n22C = (22Z, 22Z)\n22Z = (22B, 22B)\nXXX = (XXX, XXX)";
const string input =
    "LRLRRRLRRLRLLRRRLRRLLRRRLLRLRRLLRRRLRLRRRLRRLRRLRRLLLLRRRLRRLRRRLRRRLRRRLRLRRRLRLLRRRLLRLRRRLRRRLRLRRLLRLLRRLRLLRRRLLRRLRLLLRLRLRLLRRRLRLRLRRLRRRLRRLRLRRRLRRRLRRRLLLLRLLRRLLRRRLRRLRRLLRRLRRRLLRRLLLRRRLRLRLLRRLRRRLRRLRRRLLRLRRRLRLLRLLRRRLRRLLRLRRRLRRLRRRLRRLRRLRRRLRRLRRRR\n\nDQS = (CCN, PNF)\nGST = (MBG, LFG)\nSQF = (KCM, KCM)\nNXD = (DCX, PKH)\nLMN = (NTT, LJM)\nMTQ = (DHL, PVN)\nDDR = (TGF, RFT)\nHHV = (KXC, CMQ)\nJLX = (VSK, XPM)\nMLD = (BNF, FGL)\nRCQ = (TNS, MTQ)\nLPT = (FFD, RVM)\nGNV = (TQV, RBP)\nDTG = (QKC, GBN)\nQRM = (FTV, JJG)\nPJN = (FQD, CMN)\nFTV = (PCN, FHH)\nLBN = (XHT, MNB)\nLXF = (CBQ, DLB)\nFRL = (DTF, SQD)\nTMD = (HLR, MRQ)\nPKH = (MSC, BLM)\nFJB = (FRV, QPL)\nJNS = (GHQ, MXC)\nXMH = (NHH, DLT)\nFRX = (SDF, THQ)\nCVB = (BXQ, TDM)\nBRV = (XDQ, GLR)\nHRV = (SBB, QGT)\nCFC = (XHT, MNB)\nFKB = (PTG, NKC)\nVJN = (PKQ, CKN)\nNBB = (JVX, PBR)\nJRR = (HMF, CRJ)\nNKD = (HFG, JVD)\nVXK = (VXS, RCQ)\nCNG = (HJM, SSB)\nDBP = (PPP, LVK)\nMNH = (CNT, NMH)\nNRX = (CLC, QNF)\nGSS = (QKL, PJV)\nVJM = (LHL, PTP)\nPGN = (VXJ, DQK)\nBDN = (PSJ, KQG)\nVVF = (QPT, FKB)\nPMN = (KDP, XRZ)\nDFG = (GLF, XPS)\nSGS = (CKL, GHG)\nCMQ = (QFP, CVB)\nTVF = (PBP, KQQ)\nDGL = (BGP, NKD)\nNPT = (RBK, NLH)\nRBP = (PGQ, XBS)\nQXR = (NXD, MKF)\nTQV = (XBS, PGQ)\nSDD = (CPM, JJJ)\nRTL = (FBF, NSB)\nGVT = (VGS, GVX)\nLFM = (VRN, MJR)\nFJT = (FSX, NJX)\nXQG = (LTR, TPN)\nMQQ = (BXN, CBD)\nDSJ = (JDD, JDD)\nFSR = (QCD, DFC)\nTVS = (XBJ, XSC)\nGTT = (NJQ, BVV)\nDVV = (MQQ, QHQ)\nJMC = (HRQ, TSJ)\nDCX = (MSC, BLM)\nKHB = (SJV, VLM)\nVSK = (KRD, QFG)\nBFT = (LTR, TPN)\nXPS = (SGS, PRL)\nRDK = (CTN, QGQ)\nSHJ = (NKD, BGP)\nVQT = (KQJ, FKK)\nVXT = (CRK, NPK)\nGXD = (RQN, FXK)\nTQC = (CSV, FGS)\nKGS = (GNP, TGK)\nKQG = (XFG, KMG)\nHCP = (HHD, KXB)\nRSC = (SRQ, HBX)\nQSK = (PMJ, TPH)\nJSP = (NXD, MKF)\nLTK = (JJC, STN)\nXNJ = (LTK, TBQ)\nLTH = (TTM, DQB)\nLJM = (TVD, HHG)\nSVN = (FQM, XVJ)\nFSK = (DSM, NFJ)\nTLX = (QXS, SDG)\nLFB = (XSF, TCN)\nQLB = (CFC, LBN)\nKDP = (MGL, RXR)\nXNR = (QCL, BVH)\nBPL = (TLX, DQJ)\nSPP = (HXF, CBC)\nBBA = (TVC, KCX)\nDXX = (PPP, LVK)\nPPP = (XBM, JCN)\nMTV = (GLL, KSM)\nVXS = (MTQ, TNS)\nTXQ = (GFF, HPD)\nDQK = (TTQ, GSS)\nMGL = (LNN, GTT)\nXFG = (PNT, PMX)\nHBD = (JQK, LBB)\nTDP = (QMS, JNV)\nTFB = (KSV, GJJ)\nJTC = (MGG, TPC)\nGHG = (NDH, HVG)\nTVR = (QHX, GSC)\nQDR = (LVM, SVK)\nHDQ = (HBD, JPX)\nHFG = (BMS, PFX)\nFDD = (BFT, XQG)\nJCN = (TDL, XBK)\nSNS = (DMN, GVT)\nHJX = (GDM, HCZ)\nRSG = (NBV, LPR)\nBDV = (RFB, HSN)\nDVK = (LGR, MTV)\nRGL = (LJM, NTT)\nPNT = (NNP, BRR)\nKLN = (JDD, QRZ)\nTKQ = (SJS, JRR)\nSRJ = (CXL, XMH)\nTNB = (FBH, TML)\nPKQ = (MCV, LDN)\nMCV = (FSK, QJP)\nDTD = (CXB, TMD)\nHJM = (SHB, DSH)\nGLL = (QCJ, NBB)\nBBB = (GDQ, GGB)\nRFB = (NXT, MXM)\nCHX = (BFT, XQG)\nJDR = (LGR, MTV)\nPVJ = (HXK, LGG)\nDRQ = (JHP, XGJ)\nNLX = (SVK, LVM)\nPQB = (RSC, GJG)\nXNS = (LPM, QHR)\nQJN = (PBP, KQQ)\nHHG = (FJL, CMP)\nNHH = (KNG, GND)\nBCF = (NVH, FNK)\nRVM = (QPV, TQC)\nMMG = (TDP, MQM)\nSLJ = (SCL, GST)\nMGB = (CBC, HXF)\nNVB = (QPT, FKB)\nLKB = (LJP, SLZ)\nJTH = (JPC, JPC)\nVNV = (PCF, DTG)\nLBB = (FJT, HSV)\nCKR = (QKG, DCJ)\nNLH = (VTL, RDK)\nPPL = (RTL, JCX)\nHTX = (FPR, VCQ)\nJKJ = (NHG, QBX)\nTPH = (MSJ, NMP)\nPGQ = (HRV, FXB)\nPVN = (HKL, XNV)\nDRB = (LHJ, XHR)\nTGF = (VVP, GSV)\nBVV = (NKG, CTJ)\nBRR = (HHS, MCH)\nDGX = (RTL, JCX)\nCNT = (NRF, SDD)\nSLZ = (DNT, KVD)\nXVJ = (LNJ, JXV)\nXPK = (QHQ, MQQ)\nXJR = (XPK, DVV)\nJLN = (RXM, SQK)\nXDQ = (NHM, XSH)\nJVD = (BMS, PFX)\nPMP = (FRX, XLJ)\nCRT = (TMD, CXB)\nXBJ = (BPL, HXB)\nQCL = (JDR, DVK)\nCXB = (MRQ, HLR)\nNTR = (FLC, KGK)\nJCP = (JKJ, QTL)\nGNB = (THN, MXG)\nKQJ = (FLJ, DJC)\nKSM = (NBB, QCJ)\nBLA = (KVD, DNT)\nNPK = (TVF, QJN)\nBMS = (TXQ, XND)\nBNQ = (FQM, XVJ)\nPPJ = (LTH, JBV)\nFSD = (JKG, QLB)\nCFB = (PCF, DTG)\nBCR = (LMX, XJJ)\nDMN = (VGS, GVX)\nTDL = (JCP, CLX)\nGSV = (VXK, HPC)\nLRV = (CQG, LFB)\nNBK = (DMN, GVT)\nQQV = (GSC, QHX)\nPMJ = (MSJ, NMP)\nKJF = (CRQ, TCK)\nTTQ = (PJV, QKL)\nJDM = (KLK, TLS)\nKVD = (NLX, QDR)\nTRK = (FGL, BNF)\nJQG = (CST, VLQ)\nPNF = (XPG, DPP)\nDLT = (KNG, GND)\nLJP = (KVD, DNT)\nCRJ = (SRJ, QBR)\nMGG = (PNP, GVP)\nVCD = (CHF, GDV)\nTJD = (VXH, KDF)\nQBP = (VXH, KDF)\nTTM = (CHJ, VXT)\nTVC = (VJS, HTX)\nRFT = (VVP, GSV)\nXDK = (CVS, QBC)\nJMF = (NTS, VJN)\nLRR = (PTP, LHL)\nTVD = (FJL, CMP)\nPSN = (NRX, NQC)\nCKK = (TGF, RFT)\nQGT = (TTH, JGB)\nSRQ = (LHV, NJF)\nQKG = (BDV, TLB)\nMXM = (CVM, SMG)\nLCR = (XPS, GLF)\nJTT = (TSR, RDX)\nQLS = (CHF, GDV)\nTBQ = (JJC, STN)\nLBQ = (TXB, VMF)\nFMF = (SCL, GST)\nQCD = (FRL, CRL)\nTPN = (VQT, GQD)\nLLT = (SJV, VLM)\nVJC = (JXS, DFJ)\nMXC = (NDJ, KJF)\nFBF = (TKQ, BTB)\nJTJ = (VQV, DDP)\nJHP = (LPT, TBV)\nBJS = (KMX, KMX)\nFBJ = (KDP, KDP)\nTNS = (DHL, PVN)\nDQJ = (SDG, QXS)\nFQD = (DBC, GNQ)\nCKJ = (FBJ, FBJ)\nSDF = (QRM, JHV)\nKCS = (MRT, RSV)\nFVH = (GSD, XHH)\nCRK = (QJN, TVF)\nPKC = (VSK, XPM)\nDSH = (VNV, CFB)\nFLT = (LMX, XJJ)\nTCN = (TFB, JPV)\nPSJ = (XFG, KMG)\nNJF = (FPN, DTK)\nSRP = (DSJ, DSJ)\nFRV = (CFR, HVX)\nQPV = (FGS, CSV)\nTTH = (DXX, DBP)\nVRN = (GGC, DRQ)\nNKC = (RVL, PVJ)\nMPT = (KKX, LFM)\nDPT = (KKX, LFM)\nLMX = (LRJ, PMP)\nSHB = (CFB, VNV)\nGJD = (LBQ, JLL)\nQBC = (QSK, QSB)\nNHL = (XPK, DVV)\nTBJ = (KGX, FGG)\nGHQ = (KJF, NDJ)\nVHV = (LPM, QHR)\nKXB = (BBQ, SSH)\nDFC = (CRL, FRL)\nBVC = (LJP, LJP)\nJCX = (FBF, NSB)\nCLC = (QMC, NBP)\nNHG = (KGN, JSL)\nSSK = (LTK, TBQ)\nKRD = (PSN, SLF)\nJHV = (JJG, FTV)\nGGB = (LNM, SHL)\nFGS = (FJB, LLB)\nSMG = (KKQ, MSG)\nJGB = (DXX, DBP)\nCST = (RCB, LMP)\nFMK = (KGP, KSJ)\nKCL = (VLQ, CST)\nMSG = (BNQ, SVN)\nBNF = (QKN, KDG)\nRFG = (GHQ, MXC)\nDBC = (QPG, HDG)\nCMN = (GNQ, DBC)\nBTB = (SJS, JRR)\nTGM = (BVC, BVC)\nXQP = (RHG, BBB)\nLTR = (VQT, GQD)\nSST = (QXR, JSP)\nNTS = (CKN, PKQ)\nVSN = (TLS, KLK)\nNHM = (CKJ, CKJ)\nHKJ = (RFG, JNS)\nFBH = (NCC, SGM)\nLNN = (BVV, NJQ)\nCRL = (SQD, DTF)\nTDM = (LCF, JTJ)\nGDQ = (LNM, SHL)\nTCK = (TVR, QQV)\nMCH = (JCD, BKG)\nHTM = (KGP, KSJ)\nTJQ = (SPP, MGB)\nTFV = (VPQ, HVH)\nMKF = (DCX, PKH)\nLPR = (QLS, VCD)\nDFV = (PGN, LGS)\nNVH = (JRD, TGX)\nBVH = (JDR, DVK)\nKQQ = (DGH, LBJ)\nKKX = (VRN, MJR)\nPBV = (KGK, FLC)\nMRM = (NVH, FNK)\nCCN = (XPG, DPP)\nMBG = (FPD, KBG)\nDJJ = (CNG, NMX)\nTSR = (FMR, JMX)\nGDV = (MRM, BCF)\nCBD = (KBX, PHJ)\nBGP = (HFG, JVD)\nNSB = (BTB, TKQ)\nKBX = (CKR, CTM)\nHVG = (LRR, VJM)\nRMF = (CRT, DTD)\nXHH = (VFR, CHB)\nRSB = (XDQ, GLR)\nSQK = (FVD, DFV)\nLLR = (HLP, PQB)\nRDX = (JMX, FMR)\nGSD = (VFR, CHB)\nHLP = (GJG, RSC)\nSJS = (HMF, CRJ)\nRXV = (BJS, FDS)\nNBP = (VFH, KBN)\nXPG = (XCJ, BKL)\nGHC = (THN, MXG)\nGNP = (DRR, HGV)\nTJS = (KCM, HJX)\nMQM = (JNV, QMS)\nCSV = (LLB, FJB)\nKXC = (QFP, CVB)\nFSX = (RXN, KCS)\nHQC = (SNS, NBK)\nXBM = (XBK, TDL)\nBXN = (KBX, PHJ)\nHKL = (BMN, SST)\nFDF = (JLL, LBQ)\nXCJ = (PBM, MCG)\nLPJ = (KDQ, KQC)\nJQK = (FJT, HSV)\nQTL = (NHG, QBX)\nKBG = (SSK, XNJ)\nPTP = (NMJ, LRV)\nVPH = (BJS, FDS)\nTSJ = (JGM, JMF)\nMCG = (DMG, PPJ)\nGDM = (LMN, RGL)\nQPG = (SKM, XNR)\nRTS = (JPX, HBD)\nQNF = (NBP, QMC)\nBKL = (PBM, MCG)\nNRF = (JJJ, CPM)\nJVX = (HTM, FMK)\nFLC = (XVG, MNH)\nDTK = (BCR, FLT)\nVPQ = (RXV, VPH)\nLBV = (FQD, CMN)\nXRZ = (RXR, MGL)\nHRQ = (JGM, JMF)\nFGG = (SHJ, DGL)\nXGJ = (LPT, TBV)\nLLK = (JPC, FDZ)\nFKK = (DJC, FLJ)\nTJJ = (GNP, TGK)\nSHL = (BFG, DQS)\nTGK = (HGV, DRR)\nCBQ = (CHR, RHK)\nSQD = (VKX, DQR)\nQPT = (PTG, NKC)\nQKJ = (QCD, DFC)\nPBP = (DGH, LBJ)\nQKH = (DSJ, KLN)\nHVH = (RXV, VPH)\nKSJ = (TFV, HKM)\nXNV = (SST, BMN)\nVPT = (RHG, BBB)\nCPM = (BDN, MMX)\nRBK = (VTL, RDK)\nJPC = (XTJ, TVS)\nNDJ = (TCK, CRQ)\nVFR = (KPK, DRB)\nTBV = (FFD, RVM)\nQGQ = (XTL, VJC)\nPFX = (XND, TXQ)\nPBM = (DMG, PPJ)\nSSB = (SHB, DSH)\nXBS = (HRV, FXB)\nJBV = (TTM, DQB)\nRVL = (HXK, LGG)\nKBN = (TJQ, XBH)\nFXK = (TNB, TSP)\nMMT = (CRT, DTD)\nKKQ = (BNQ, SVN)\nHSV = (NJX, FSX)\nGGC = (JHP, XGJ)\nLVK = (JCN, XBM)\nHCZ = (RGL, LMN)\nGVF = (KXC, CMQ)\nRLQ = (MPT, DPT)\nTPX = (SQK, RXM)\nTGX = (CVC, GXD)\nVTL = (CTN, QGQ)\nMMX = (PSJ, KQG)\nSTN = (DJJ, XSQ)\nJKG = (CFC, LBN)\nPRL = (GHG, CKL)\nXDL = (PKC, JLX)\nPHJ = (CKR, CTM)\nXND = (HPD, GFF)\nVXH = (TGM, TGM)\nRQN = (TSP, TNB)\nHBX = (LHV, NJF)\nNKG = (CVL, FSD)\nCVC = (FXK, RQN)\nFPD = (XNJ, SSK)\nJPX = (JQK, LBB)\nVFH = (XBH, TJQ)\nCTJ = (CVL, FSD)\nFJL = (CHX, FDD)\nMRQ = (TJJ, KGS)\nHSN = (MXM, NXT)\nTML = (SGM, NCC)\nQHR = (HKQ, GPP)\nVKX = (DGX, PPL)\nAAA = (VHV, XNS)\nCFR = (JMC, KBM)\nPRT = (HXQ, JTT)\nBKG = (GHC, GNB)\nSCL = (MBG, LFG)\nDPP = (BKL, XCJ)\nXHS = (BVC, LKB)\nCHB = (KPK, DRB)\nTLF = (BVR, MMG)\nQRZ = (KCX, TVC)\nFVD = (PGN, LGS)\nCTN = (XTL, VJC)\nKGK = (MNH, XVG)\nVLM = (LCR, DFG)\nDSM = (TPX, JLN)\nSGM = (FDF, GJD)\nXQQ = (LDR, MHH)\nSDG = (RMF, MMT)\nHVX = (JMC, KBM)\nJRD = (CVC, GXD)\nGLR = (NHM, XSH)\nPMX = (NNP, BRR)\nXLJ = (THQ, SDF)\nXBK = (JCP, CLX)\nXLH = (XDL, XLV)\nMTD = (CLB, ZZZ)\nNFA = (MGL, RXR)\nGJJ = (RSH, HCP)\nCXL = (NHH, DLT)\nGSC = (XDK, JTQ)\nCRQ = (QQV, TVR)\nLRJ = (FRX, XLJ)\nCLB = (VHV, XNS)\nCMM = (RLQ, RQQ)\nDHL = (XNV, HKL)\nXSQ = (CNG, NMX)\nVVP = (VXK, HPC)\nCHJ = (CRK, NPK)\nQKN = (LXF, RBQ)\nFQM = (LNJ, JXV)\nJJG = (PCN, FHH)\nDCL = (RQQ, RLQ)\nBBQ = (NVB, VVF)\nQMS = (XXP, RSG)\nNFJ = (JLN, TPX)\nRQQ = (DPT, MPT)\nXSF = (TFB, JPV)\nPNP = (XMQ, GNR)\nQBX = (KGN, JSL)\nJPV = (GJJ, KSV)\nXCG = (LLR, GKQ)\nBFG = (PNF, CCN)\nGRJ = (TPC, MGG)\nQCJ = (PBR, JVX)\nLDR = (PBV, NTR)\nZZZ = (XNS, VHV)\nGVX = (LPJ, TPB)\nGBN = (XJR, NHL)\nHXB = (TLX, DQJ)\nJLL = (VMF, TXB)\nKBM = (HRQ, TSJ)\nXSH = (CKJ, MHM)\nHXF = (JDM, VSN)\nRXR = (LNN, GTT)\nSLF = (NQC, NRX)\nQPL = (HVX, CFR)\nCVM = (KKQ, MSG)\nCHR = (KCC, JBD)\nFGL = (QKN, KDG)\nGNQ = (HDG, QPG)\nSBB = (TTH, JGB)\nXMQ = (RSB, BRV)\nSPD = (SRP, SRP)\nJDD = (TVC, KCX)\nFXB = (SBB, QGT)\nRXM = (DFV, FVD)\nFDS = (KMX, VKC)\nCQG = (TCN, XSF)\nCHF = (BCF, MRM)\nQHX = (JTQ, XDK)\nMJR = (DRQ, GGC)\nDRA = (XTJ, TVS)\nKCX = (VJS, HTX)\nPCN = (HHV, GVF)\nFFD = (TQC, QPV)\nCBC = (VSN, JDM)\nRPK = (MHH, LDR)\nJTQ = (CVS, QBC)\nSSH = (VVF, NVB)\nKMG = (PMX, PNT)\nJBD = (CQS, XCG)\nDQB = (VXT, CHJ)\nQSB = (PMJ, TPH)\nKGX = (DGL, SHJ)\nTSP = (TML, FBH)\nLHV = (FPN, DTK)\nLGR = (KSM, GLL)\nCLX = (QTL, JKJ)\nPSA = (LMN, RGL)\nMXG = (KHB, LLT)\nTLB = (HSN, RFB)\nNQC = (CLC, QNF)\nNMJ = (CQG, LFB)\nNXT = (SMG, CVM)\nLHL = (LRV, NMJ)\nVQV = (FVH, RDN)\nKDQ = (TJD, QBP)\nDFJ = (TRK, MLD)\nLBJ = (SQF, TJS)\nCVS = (QSB, QSK)\nJSL = (QKJ, FSR)\nQKC = (NHL, XJR)\nLCF = (VQV, DDP)\nCKL = (HVG, NDH)\nHKQ = (XLH, MDN)\nDDP = (RDN, FVH)\nRHG = (GDQ, GGB)\nCKN = (LDN, MCV)\nRXN = (MRT, RSV)\nHHS = (JCD, BKG)\nPJV = (GRJ, JTC)\nHPC = (VXS, RCQ)\nHGV = (LNS, NPT)\nFMR = (QJD, TLF)\nXTJ = (XSC, XBJ)\nTHN = (LLT, KHB)\nTLS = (PRT, DBJ)\nKGP = (HKM, TFV)\nDNT = (QDR, NLX)\nLLB = (QPL, FRV)\nBLM = (VGC, TBJ)\nGND = (XQP, VPT)\nMSJ = (SPD, DRV)\nLVM = (FMF, SLJ)\nTPB = (KQC, KDQ)\nRHK = (KCC, JBD)\nLGG = (DDR, CKK)\nLDN = (FSK, QJP)\nJXV = (TRC, HQC)\nGPP = (XLH, MDN)\nTXB = (RTS, HDQ)\nQFG = (SLF, PSN)\nJMX = (QJD, TLF)\nQFP = (TDM, BXQ)\nXVG = (NMH, CNT)\nKCC = (XCG, CQS)\nDQR = (DGX, PPL)\nFDZ = (TVS, XTJ)\nXHR = (JTH, LLK)\nXXP = (NBV, LPR)\nJNV = (RSG, XXP)\nHXQ = (TSR, RDX)\nDBJ = (JTT, HXQ)\nLFV = (CLB, CLB)\nHKM = (HVH, VPQ)\nNMH = (SDD, NRF)\nFHH = (GVF, HHV)\nQMC = (KBN, VFH)\nFPN = (BCR, FLT)\nDRV = (SRP, QKH)\nNNP = (MCH, HHS)\nNJQ = (CTJ, NKG)\nMRT = (JQG, KCL)\nKLK = (PRT, DBJ)\nLHJ = (JTH, JTH)\nVGS = (LPJ, TPB)\nQBR = (CXL, XMH)\nFXS = (JNS, RFG)\nDTF = (VKX, DQR)\nQHQ = (BXN, CBD)\nBXQ = (LCF, JTJ)\nGVP = (GNR, XMQ)\nVJS = (VCQ, FPR)\nHMF = (QBR, SRJ)\nCMP = (FDD, CHX)\nQJD = (BVR, MMG)\nXLV = (PKC, JLX)\nQKL = (JTC, GRJ)\nPCF = (GBN, QKC)\nLNM = (BFG, DQS)\nSJV = (LCR, DFG)\nKPK = (LHJ, LHJ)\nGNR = (BRV, RSB)\nNCC = (FDF, GJD)\nRSH = (KXB, HHD)\nMNB = (DCL, CMM)\nXTL = (JXS, DFJ)\nVKC = (LFV, MTD)\nFLJ = (GNV, BPQ)\nKCM = (GDM, GDM)\nXBH = (SPP, MGB)\nLMP = (PJN, LBV)\nBVR = (TDP, MQM)\nSKM = (BVH, QCL)\nRBQ = (CBQ, DLB)\nJCD = (GNB, GHC)\nMHM = (FBJ, PMN)\nHDG = (XNR, SKM)\nKQC = (TJD, QBP)\nNMX = (SSB, HJM)\nHHD = (SSH, BBQ)\nNDH = (LRR, VJM)\nDJC = (BPQ, GNV)\nGKQ = (HLP, PQB)\nMHH = (PBV, NTR)\nKDF = (TGM, XHS)\nQJP = (DSM, NFJ)\nVMF = (RTS, HDQ)\nNBV = (QLS, VCD)\nNJX = (KCS, RXN)\nLGS = (VXJ, DQK)\nPBR = (FMK, HTM)\nGJG = (HBX, SRQ)\nMDN = (XLV, XDL)\nMSC = (VGC, TBJ)\nNTT = (TVD, HHG)\nFPR = (XQQ, RPK)\nDGH = (SQF, SQF)\nHLR = (KGS, TJJ)\nLNS = (RBK, NLH)\nSVK = (FMF, SLJ)\nXSC = (HXB, BPL)\nRSV = (JQG, KCL)\nXJJ = (LRJ, PMP)\nDLB = (RHK, CHR)\nKNG = (XQP, VPT)\nXHT = (DCL, CMM)\nXPM = (QFG, KRD)\nBPQ = (RBP, TQV)\nQXS = (MMT, RMF)\nCTM = (DCJ, QKG)\nCQS = (GKQ, LLR)\nPTG = (PVJ, RVL)\nNMP = (SPD, DRV)\nDCJ = (TLB, BDV)\nRDN = (GSD, XHH)\nKMX = (LFV, LFV)\nKGN = (FSR, QKJ)\nVCQ = (XQQ, RPK)\nJJC = (DJJ, XSQ)\nLPM = (HKQ, GPP)\nGLF = (SGS, PRL)\nTRC = (NBK, SNS)\nHPD = (HKJ, FXS)\nJGM = (NTS, VJN)\nJXS = (TRK, MLD)\nKDG = (RBQ, LXF)\nVLQ = (RCB, LMP)\nLFG = (KBG, FPD)\nLNJ = (TRC, HQC)\nCVL = (QLB, JKG)\nBMN = (QXR, JSP)\nKSV = (RSH, HCP)\nRCB = (LBV, PJN)\nFNK = (TGX, JRD)\nHXK = (CKK, DDR)\nGQD = (FKK, KQJ)\nVXJ = (GSS, TTQ)\nDMG = (JBV, LTH)\nVGC = (FGG, KGX)\nTHQ = (QRM, JHV)\nGFF = (FXS, HKJ)\nJJJ = (BDN, MMX)\nDRR = (NPT, LNS)\nTPC = (PNP, GVP)";

Parser<Direction> parseDirection =
    Parse.Char('R').Select(_ => Direction.Right)
         .Or(Parse.Char('L').Select(_ => Direction.Left));

Parser<IEnumerable<Direction>> parseDirections =
    parseDirection.Until(Parse.LineEnd);

Parser<string> parseNodeName =
    Parse.Identifier(Parse.LetterOrDigit, Parse.LetterOrDigit);

Parser<RawNode> parseNode =
    from name in parseNodeName.Token()
    from _ in Parse.Char('=')
    from __ in Parse.WhiteSpace.Many()
    from ___ in Parse.Char('(')
    from left in parseNodeName.Token()
    from ____ in Parse.Char(',')
    from right in parseNodeName.Token()
    from _____ in Parse.Char(')')
    select new RawNode(name, left, right);

Parser<IEnumerable<RawNode>> parseNodeList =
    parseNode.DelimitedBy(Parse.LineEnd);

Parser<Input> parseInput =
    from directions in parseDirections
    from _ in Parse.LineEnd
    from nodes in parseNodeList
    select new Input(directions, nodes);

var parsedInput = parseInput.Parse(input);
var nodesLookup = parsedInput.Nodes
                             .Select(n => new Node(n.Name))
                             .ToDictionary(n => n.Name);

foreach (var node in parsedInput.Nodes)
{
    var realNode = nodesLookup[node.Name];

    realNode.LeftDestination = nodesLookup[node.LeftDestination];
    realNode.RightDestination = nodesLookup[node.RightDestination];
}

Node startingNode = nodesLookup["AAA"];
var path = FollowDirections(startingNode, RepeatInfinitely(parsedInput.Directions))
   .TakeUntil(n => n.Name == "ZZZ");

int part1 = path.Count();
Console.WriteLine(part1);

var startingNodes = nodesLookup.Values.Where(n => n.Name.EndsWith('A'));

var pathLengths = startingNodes.Select(start => FollowDirections(start, RepeatInfinitely(parsedInput.Directions))
                                               .TakeUntil(current => current.Name.EndsWith('Z'))
                                               .Count())
                               .ToArray();

int smallestLength = pathLengths.Min();
long part2;

var stopwatch = Stopwatch.StartNew();

for (int i = 2;; i++)
{
    part2 = (long) smallestLength * i;
    bool nonMultipleFound = false;

    for (int j = 0; j < pathLengths.Length; j++)
        if (part2 % pathLengths[j] != 0)
        {
            nonMultipleFound = true;
            break;
        }

    if (!nonMultipleFound)
        break;
}

stopwatch.Stop();

Console.WriteLine(part2);
Console.WriteLine(stopwatch.Elapsed);

Console.WriteLine("Done");
return;

static IEnumerable<T> RepeatInfinitely<T>(IEnumerable<T> source)
{
    var enumerable = source.ToArray();
    
    while (true)
    {
        foreach (var item in enumerable)
        {
            yield return item;
        }
    }
    // ReSharper disable once IteratorNeverReturns
}

static IEnumerable<Node> FollowDirections(Node startingNode, IEnumerable<Direction> directions)
{
    Node current = startingNode;
    
    foreach (var direction in directions)
    {
        current = current.Get(direction);
        yield return current;
    }
}

enum Direction
{
    Right,
    Left,
}

record Input(IEnumerable<Direction> Directions, IEnumerable<RawNode> Nodes);

record RawNode(string Name, string LeftDestination, string RightDestination);

[DebuggerDisplay($"{{Name}}: {{LeftDestination.Name}}/{{RightDestination.Name}}")]
class Node
{
    public string Name { get; }
    public Node LeftDestination { get; set; }
    public Node RightDestination { get; set; }

    public Node Get(Direction direction) =>
        direction switch
        {
            Direction.Left => LeftDestination,
            Direction.Right => RightDestination,
            _ => throw new InvalidOperationException($"Invalid direction {direction}."),
        };

    public Node(string name)
    {
        Name = name;
        LeftDestination = this;
        RightDestination = this;
    }
}