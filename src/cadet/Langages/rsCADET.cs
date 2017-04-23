/*=========================================================================
 Nom de classe : rsCADET.cs
 Info Version  :  boutons, label, tooltip, menus francais
 Copyright : 04-05/2008 Master 2 CCI /  UFRT / UE6 Professeur :  M.  DI SCALA
 Auteur(s) : Mehdi ALLAS, JF. PACORY, Mahmoud BOUKERROUI, Hassan RAHHOU
 Etat :   Version initiale
 --------------------------------------------------------------------------
 R�vision(s) :
 ========================================================================== */
#define FRENCH

using System;
using System.Collections.Generic;
#if (Linq35)
using System.Linq;           
#endif

namespace CADET
{
     static partial class rsCADET
    {

        //--[.cs]---------------------- RoutineW -------------------------------------------------

        public static string CRLF = "\r\n";
        public static string CR = "\r";
        public static string LF = "\n";

        //------------------------------ General ----------------------------------------------------

        public static string ksCopyRight = "CADET pour Windows v1.0 Copyright (c) 2008 xxx. " +
            "Tous droits r�serv�s.";
        public static string ksNomProjet = "CADET";
        public static string ksCADETindows = "CADET pour Windows";
        public static string VerCAP = "CADET v1.0"; // 10 car. maxi
        public static string Version = "Version 1.0 du xx.xx.Xxxx";
        public static string VerCAPLong = "CADET " + Version;
        public static string Numero_Serie = "20082000";
        public static string ksCAP = "CADET";
        public static string Nom_Fic_Cfg = "CADET";
        public static string sDialLAuteurs = "xxxx";
        public static string CopyrightText = "xxxxxx";
        public static string sSiteInternet = "http://www.xxx.xxxx";
        public static string sAdresseMel = "xxx@xxx.xx";
        public static string sMailToPLOG = "mailto:%s?subject=[%s] Demande d'Assistance";
        public static string buttonOKToolTip = "Valider [F10]";
        public static string buttonAnnulerToolTip = "Abandonner [Echap]";
        public static string buttonAideToolTip = "Consultation de l'aide en ligne [F1]";
        public static string buttonOKText = "&OK";
        public static string buttonAnnulerText = "Annuler";
        public static string buttonAideText = "&Aide";
        public static string sPasDeLibelle = ".Pas de libell�";
        public static string Cle = "cle";
        public static string sVersionNonEnregistree = "** Version non enregistr�e **";
        public static string ksgFonctionNonDispo = "Fonction en cours de programmation" + CRLF + CRLF +
            "Version active : " + Version;
        public static string sEvaluation = "EVALUATION";
        public static string sEditeur = "NOTEPAD.EXE";
        public static string ksExplorer = "Explorer";
        public static string sExtension_PRN = "csv";
        public static string sExtension_DOC = "txt";
        public static string sExtension_HTML = "html";
        public static string sOutilsMinitel = @"C:\Program Files\Accessoires\HyperTerminal\HyperTrm.exe";

        //----------------- Codes du syst�me d"aide -------------------------------------

        //COD_AIDE.INC"
        // A definir

        //*----------------------------------------------------------------------------

        public static string ksCADETHlp = "CADET.CHM";
        public static string ksCADETExe = @"\CADET.EXE";
        public static string ksCADETIni = "CADET.INI";
        public static string ksErreurLog = "erreurs.log";


        //--[.cs]---------------------- MenuVarW -------------------------------------------------

        public static string sNomi = "Imprimante par d�faut";
        public static string HKEY_ASTUCES = "ASTUCES";
        public static string HKEY_IMPRIMANTE = "IMPRIMANTE";
        public static string HKEY_COULEURS = "COULEURS";
        public static string HKEY_EXPORT = "EXPORT";
        public static string HKEY_ENVT = "ENVIRONNEMENT";
        public static string HKEY_BUREAU = "BUREAU";
        public static string HKEY_OUTILS = "OUTILS";

        //--[.cs]---------------------- MenuPal --------------------------------------------------

        public static string sAnnotationEnCours = " Annotation en cours....";
        public static string sMenuPalCADET = "Menu principal de CADET - Appuyez sur [F1] pour obtenir de l'aide";
        public static string sVsQuittezCADETSauveNecessaire = "Vous quittez CADET et des donn�es ont chang� :"
            + CRLF + "N'oubliez pas d'effectuer des sauvegardes" + CRLF +
            "r�guli�res de votre comptabilit�.";
        public static string sAnc_ToolTip =
            "What'S up SUpeR-crACKerZ ? pLeASE COntAcT-Me BEFoRe stArTiNG : %s";

        public static string scxAAidesurlaideToolTip = "Aide sur le fonctionnement du syst�me d'aide";
        public static string scxAAproposToolTip = "Version du programme et informations compl�mentaires";
        public static string scxAAssistanceTechniqueToolTip =
            "Envoyer un courrier �lecronique pour obtenir de l'assistance";
        public static string scxAContenuToolTip = "Appel de l'aide contextuelle sur le choix en cours";
        public static string scxAEnregistrementToolTip =
            "Saisie des informations d'enregistrement de la licence de CADET";
        public static string scxASiteWebCADETToolTip =
            "Acc�s au site internet du programme pour plus d'informations et actualit�s";
        public static string scxCActivitesToolTip = "Cr�e/modifie les activit�s du dossier";
        public static string scxCCreationJournauxToolTip = "Cr�e/modifie les journaux du dossier";
        public static string scxCCreationPlancomptableToolTip = "Cr�e/modifie le plan comptable du dossier";
        public static string scxCElementsdupatrimoineToolTip = "Gestion des �l�ments du patrimoine";
        public static string scxCGenerationEcrituresToolTip = "Exporte votre dossier comptable sous diff�rents formats";
        public static string scxCPCreationmanuelleCompteToolTip = "Cr�e les comptes individuellement";
        public static string scxCPImportationComptesToolTip = "Importe un fichier texte contenant un plan comptable";
        public static string scxCRAbonnementToolTip = "Importe des �critures r�p�titives";
        public static string scxCRExtractionparMinitelToolTip = "Transfert des �crans Minitel au format CADET";
        public static string scxCRImportedesecrituresToolTip = "Importe des �critures ext�rieures � CADET";
        public static string scxCRecettesdepensesToolTip = "Saisie rapide des d�caissements/encaissements";
        public static string scxCRecuperedesecrituresToolTip = "Acc�s � diff�rents types d'importations d'�critures";
        public static string scxCSaisiedesecrituresToolTip = "Saisie des �critures comptables dans les journaux";
        public static string scxCreationToolTip = "Param�trages comptables et saisie des �critures";
        public static string scxEBrouillarddesaisieToolTip = "Edite et corrige les �critures non mises � jour";
        public static string scxECentralisateurToolTip = "Edite le r�capitulatif de tous les journaux";
        public static string scxEEditionDossierToolTip = "Donne les diff�rents �l�ments courants de ce dossier";
        public static string scxEEditionJournauxToolTip = "Edite tout ou partie de vos journaux";
        public static string scxEEditionPlancomptableToolTip = "Edite votre Plan comptable";
        public static string scxEGrandlivreToolTip = "Edite votre Grand-livre et permet le pointage des comptes";
        public static string scxEInventaireduPatrimoineToolTip = "Etat d'inventaire des �l�ments du patrimoine";
        public static string scxERechercheToolTip = "Recherche d'une �criture dans la comptabilit�";
        public static string scxEbaLanceToolTip = "Edite une Balance pour une p�riode donn�e";
        public static string scxEditionToolTip = "Impression/visualisation des �tats comptables standards";
        public static string scxFCCatalogueToolTip = "Affiche le contenu du r�pertoire choisi";
        public static string scxFCCopierunfichier1ToolTip = "Copie un fichier";
        public static string scxFCEditeunfichierToolTip = "Lance l'�dition du fichier choisi avec l'�diteur indiqu� dans CADET.INI";
        public static string scxFCImprimeunfichierToolTip = "Imprime un fichier";
        public static string scxFCLisunfichierToolTip = "Affiche un fichier .DOC ou .PRN";
        public static string scxFCNouveaurepertoireToolTip = "Cr�e un r�pertoire";
        public static string scxFCRenommeunfichierToolTip = "Renomme un fichier";
        public static string scxFCSupprimeunfichierToolTip = "Supprime un fichier";
        public static string scxFCommandesToolTip = "Ensemble d'outils pour les fichiers et r�pertoires";
        public static string scxFERestaurationToolTip = "Reprend vos fichiers comptables sauvegard�s";
        public static string scxFESauvegardeToolTip = "Sauvegarde votre comptabilit�";
        public static string scxFEnregistreToolTip = "Sauvegarde/Restauration des fichiers comptables";
        public static string scxFInformationsToolTip = "Affiche les caract�ristiques de votre comptabilit�";
        public static string scxFNouveauToolTip = "Cr�ation d'un nouveau dossier comptable";
        public static string scxFOuvrirToolTip = "Ouverture d'un dossier existant";
        public static string scxFQuitteCAPWToolTip = "Quitte d�finitivement CADET";
        public static string scxFichierToolTip = "Gestion des dossiers comptables et utilitaires g�n�raux";
        public static string scxMDateToolTip = "Modifie la date actuelle";
        public static string scxMECouleurscranToolTip = "Modifie les Couleurs �cran de CADET";
        public static string scxMEImprimanteToolTip = "Contr�le du param�trage de l'impression";
        public static string scxMEParamDevisesToolTip = "Permet de param�trer les taux de conversion des devises";
        public static string scxMEParametresCAPToolTip = "Modifie certains �l�ments du dossier et l'environnement de travail de CADET";
        public static string scxMESonToolTip = "Supprime momentan�ment les avertissements Sonores";
        public static string scxMEnvironnementToolTip = "Modifie les Param�tres courants de CADET ";
        public static string scxMHeureToolTip = "Modifie l'heure actuelle";
        public static string scxMReinitialisationToolTip = "Ferme le dossier en cours tout en restant dans CADET";
        public static string scxModificationToolTip = "Param�trage de l'environnement de travail de CADET";
        public static string scxOCClotureAnnuelleToolTip = "Cl�ture l'exercice en cours et reporte les soldes des comptes";
        public static string scxOCClotureMensuelleToolTip = "Rend impossibles les saisies ou/et modifications ult�rieures sur un mois";
        public static string scxOCloturedescomptesToolTip = "Cl�ture un mois ou rouvre l'exercice comptable";
        public static string scxOEBalanceAnnuelleToolTip = "Cr�e un tableau de bord annuel";
        public static string scxOEBilanToolTip = "G�n�re le bilan d�taill� du dossier en cours";
        public static string scxOEComptederesultatToolTip = "Propose le Compte de R�sultat d�taill� de cette Comptabilit�";
        public static string scxOEGrandesclassesToolTip = "Donne les grandes classes de cette comptabilit�";
        public static string scxOEtatsdesyntheseToolTip = "Cr�e les �tats r�capitulatifs de votre comptabilit�";
        public static string scxOMDepointageduncompteToolTip = "Retire tous les pointages port�s sur un compte.";
        public static string scxOMMajPartielleToolTip = "Met � jour vos comptes depuis la derni�re mise � jour";
        public static string scxOMRegenerationToolTip = "Reconstruit le grand-livre � partir des fichiers ECRITURE et COMPTES";
        public static string scxOMiseajourdescomptesToolTip = "Met � jour votre comptabilit� (sauvegarde conseill�e)";
        public static string scxOMouvementsdescomptesToolTip = "Donne les mouvements d'un compte par mois sur l'exercice";
        public static string scxOTresorerieToolTip = "Affiche mensuellement un �tat de votre tr�sorerie ";
        public static string scxOptionsToolTip = "Impression/visualisation des �tats de gestion/situation";

        //------------------------------ comptes ----------------------------------------------------

        public static string sSelectionCompteToolTip = "S�lection d'un compte dans le plan comptable (ou touche [F2])";

        //------------------------------ devises----------------------------------------------------

        public static string sSelectionDeviseToolTip = "S�lection d'une devise dans la liste (ou touche [F4])";

        //--[.cs]---------------------- MenuFicW -------------------------------------------------

        public static string MsgErr101 = "Mise � jour totale non viable";
        public static string MsgErr104 = "Mise � jour Impossible";
        public static string MsgErr105 = "Ecriture Impossible";
        public static string MsgErr106 = "lors de la mise � jour";
        public static string MsgErr108 = "Ecriture(s) non sold�e(s)";
        public static string MsgErr120 = "arr�t�e et incompl�te. Contr�lez l'espace disponible sur le support de ";
        public static string MsgErr155 = "Reclassement impossible";
        public static string MsgErr119 = "Aucun dossier trouv� ou version incompatible";
        public static string MsgErr110 = "R�pertoires identiques";
        public static string MsgErr137 = "Importation stopp�e";

        //--[.cs]---------------------- e_Synth --------------------------------------------------

        public static string AvertESY01 = "Impossible de charger les soldes des comptes (Synth�se).";

        //-----------------------------/ divers visu /------------------------------------------------

        public static string MessageVisuStandard = "Cliquez sur [OK] pour terminer ; vous pouvez �galement affiner votre visualisation (Voir [F1]).";

        //--[.cs]---------------------- GenCAPw ------------------------------------------------

        public static string kgM502 = "Options  SOS-DBF et 89/90 incompatibles.";
        public static string kgM506 = "Une extension de dossier doit �tre pr�cis�e.";
        public static string kgM508 = "Fichier(s) g�n�r�(s).";
        public static string MsgErr190 = "Options choisies non compatibles entre elles.";
        public static string MsgErr191 = "Acc�s au dossier choisi impossible.";
        public static string MsgErr193b = "Fichier ECR.DBF non cr��";
        public static string MsgErr193 = "Fichier COMPTES non ouvert";
        public static string MsgErr194 = "Probl�me sur lecture des �critures/comptes ou �criture COMPTES.PRN.";
        public static string MsgErr195 = "Fichier ECR.PRN non cr��";
        public static string MsgErr192 = "Vous devez pr�ciser un exercice correct";
        public static string sGenerationterminee = "G�n�ration termin�e !";
        public static string bcChampsConstantsToolTip = "Export � champs constants";
        public static string bcDBFToolTip = "Fichier d'�critures au format dBASE";
        public static string SelCodeJournalToolTip = "G�n�ration d'un seul journal ; choisir le code du journal ; rien pour tous";
        public static string cMoisToolTip = "Cocher pour g�n�rer les �critures d'un mois ; toutes sinon";
        public static string cbMoisToolTip = "Indiquer le mois � g�n�rer (format mm aaaa)";
        public static string bcANSIToolTip = "Utiliser la table de caract�res Windows/ANSI ; sinon table DOS/OEM";
        public static string bcSOSToolTip = "R�cup�ration d'�critures";
        public static string bcCAP92ToolTip = "Export vers une comptabilit� CAP92";
        public static string eDestinationToolTip = "Destination de l'exportation";
        public static string sbSelectRepertoireToolTip = "S�lection d'un r�pertoire";
        public static string sbSelectionDossierToolTip = "S�lection du dossier � traiter";

        //--[.designer.cs]--------------- GenCAPw ------------------------------------------------

        public static string eChoixDossierToolTip = "Extension du dossier � traiter ; [F2] pour s�lectionner un dossier";
        public static string CBParametreToolTip = "Transfert des comptes, activit�s et journaux";
        public static string Text = "Exportation des �critures";
        public static string Label1CGText = "Exportation d'un dossier comptable";
        public static string Label2CGText = "&Dossier :";
        public static string Label3CGText = "Des&tination :";
        public static string Label6CGText = "&Journal :";
        public static string FormatText = " Format ";
        public static string bcChampsConstantsText = "&Champs fixes";
        public static string CBParametreText = "&Param�tres";
        public static string bGenereText = "&G�n�rer";
        public static string cMoisText = "&Mois :"; //"&Month :";

        //--[.designer.cs]--------------- Motdepasse --------------------------------------------

        public static string SaisieMotDePasseToolTip = "Saisissez le mot de passe du dossier en cours";
        public static string SaisieMotDePasseText = "Mot de passe du dossier";
        public static string lbEntrezMotdePasseText = "&Entrez le mot de passe :";
        public static string cbMasqueMDPToolTip = "Ne pas afficher le mot de passe en clair";
        public static string cbMasqueMDPText = "&Masquer";
        public static string MsgErr073 = "Le mot de passe que vous avez saisi est incorrect.";

        //--[.cs]---------------------- dateheure ---------------------------------------------

        public static string DialDateHeureToolTip = "Entrez la nouvelle valeur ; [F10] = Valider, [�chap] = abandonner";
        public static string lDateHeureTextH = "Nouvelle &heure :";
        public static string DialDateHeureTextH = "Modifier l'heure syst�me";
        public static string lDateHeureTextD = "Nouvelle &date :";
        public static string DialDateHeureTextD = "Modifier la date syst�me";
        public static string ksEditMasqueHeure = "!00:00:99;1; ";
        public static string ksEditMasqueDate = "!00/00/0000;1; ";

        //--[.designer.cs]--------------- calculette --------------------------------------------

        public static string CalculetteToolTip = "Calculette de CADET ; [F10] pour exporter le r�sultat en saisie";
        public static string CalculetteText = "Calculette";
        public static string cbDeviseParDefautToolTip = "Conversion du montant affich� dans une devise";
        public static string bEffaceToolTip = "Efface la saisie actuelle";
        public static string bEffaceText = "&C";
        public static string bMemMoinsToolTip = "Soustraction de la m�moire, de la valeur affich�e";
        public static string bMemMoinsText = "M-";
        public static string bMemPlusToolTip = "Mise en m�moire de la valeur affich�e";
        public static string bMemRecallClearToolTip = "Rappel registre m�moire";
        public static string bMemRecallClearText = "RC";

        //--[.designer.cs]--------------- calendrier --------------------------------------------

        public static string CalendrierToolTip = "Calendrier de CADET ; utilisez gauche/droite pour changer le mois";
        public static string CalendrierText = "Calendrier";

        //--[.cs]---------------------- menucdew ------------------------------------------------

        public static string MsgErr50 = "Fichier non trouv�";
        public static string MsgErr54 = "Impossible de renommer le fichier";
        public static string ksen = "en";
        public static string MsgErr55 = "Copie Impossible du fichier";
        public static string ksvers = "vers";
        public static string MessErr57 = "Changement de r�pertoire non effectu�";
        public static string ksFlistedesfichiers = "; [F2] : liste des fichiers";
        public static string ksDe = "&De :";
        public static string ksParametrerunoutil = "Param�trer un outil";
        public static string ksEntrezlenomdeloutiletindiquezso = "Entrez le nom de l'outil et indiquez son chemin d'acc�s";
        public static string ksNom = "&Nom :";
        public static string ksAcces = "A&cc�s :";
        public static string ksImportationdecritures = "Importation d'�critures";
        public static string ksEntrezlenomdufichierimporter = "Entrez le nom du fichier � importer";
        public static string ksImportationdecomptes = "Importation de comptes";
        public static string ksImportationdecrituresdabonnemen = "Importation d'�critures d'abonnement";
        public static string ksEntrezlenomdufichierdabonnement = "Entrez le nom du fichier d'abonnement";
        public static string ksLireunfichier = "Lire un fichier";
        public static string ksEntrezlenomdufichiervisualiser = "Entrez le nom du fichier � visualiser";
        public static string ksCreerunnouveaudossier = "Cr�er un nouveau dossier";
        public static string ksEntrezlenomdudossiercreer = "Entrez le nom du dossier � cr�er";
        public static string ksChangerderepertoirecourant = "Changer de r�pertoire courant";
        public static string ksEntrezlenomdunouveaurepertoire = "Entrez le nom du nouveau r�pertoire";
        public static string ksSupprimerunfichier = "Supprimer un fichier";
        public static string ksEntrezlenomdufichiersupprimer = "Entrez le nom du fichier � supprimer";
        public static string cbNettoieText = "&Effacer";
        public static string cbNettoieToolTip = "Proc�de � l'effacement complet avant suppression";
        public static string ksImprimerunfichier = "Imprimer un fichier";
        public static string ksEntrezlenomduFichierimprimer = "Entrez le nom du Fichier � imprimer";
        public static string ksModifierunfichier = "Modifier un fichier";
        public static string ksEntrezlenomdufichiermodifier = "Entrez le nom du fichier � modifier";
        public static string ksCopierunfichier = "Copier un fichier";
        public static string ksEntrezlenomdufichiercopier = "Entrez le nom du fichier � copier";
        public static string ksEntrezlenomduFichiersourcecopie = "Entrez le nom du Fichier source � copier";
        public static string ksEntrezlenomduFichiercible = "Entrez le nom du Fichier cible";
        public static string ksRenommerunfichier = "Renommer un fichier";
        public static string ksEntrezlenomdufichierrenommer = "Entrez le nom du fichier � renommer";
        public static string ksEntrezlenouveaunomduFichier = "Entrez le nouveau nom du Fichier";
        public static string ksExecuterunfichier = "Ex�cuter un fichier";
        public static string ksEntrezlenomdufichierexecuter = "Entrez le nom du fichier � ex�cuter";
        public static string ksECRITUREABONNEMENTPLANvenir = "##  ECRITURE, ABONNEMENT, PLAN � venir ##";
        public static string ksSuppressiondundossiercomptable = "Suppression d'un dossier comptable";
        public static string ksVousetessurlepointdesupprimerle = "Vous �tes sur le point de supprimer le dossier ";
        public static string ksettouslesfichiersassociescedoss = "et tous les fichiers associ�s � ce dossier.";
        public static string ksConfirmezvouscettesuppression = "Confirmez-vous cette suppression ?";
        public static string MessErr58 = "Suppression non r�alis�e de";
        public static string ksSelectiondelapplication = "S�lection de l'application";
        public static string ksApplicationsexeexeTouslesfichie = "Applications (*.exe)|*.exe|Tous les fichiers (*.*)|*.*|Fichiers texte (*.txt)|*.txt|Fichiers Abonnement (*.abt)|*.abt|Fichiers Import CAP (*.prn)|*.prn";
        public static string ksSelectiondunfichier = "S�lection d'un fichier";
        public static string ksTouslesfichiersFichierstextetxt = "Tous les fichiers (*.*)|*.*|Fichiers texte (*.txt)|*.txt|Fichiers Abonnement (*.abt)|*.abt|Fichiers Import CAP (*.prn)|*.prn|Dossiers CAP (DOSSIER.*)|DOSSIER.*";

        //--[.designer.cs]--------------- menucdew ------------------------------------------------

        public static string ChangeDlgText = "Copie / Renommer";
        public static string LabVersText = "&Vers :";

        //--[.cs]---------------------- sysinfo -----------------------------------------------

        public static string ksc_sysinfo08 = "Win32s sous Windows 3.1";
        public static string ksc_sysinfo09 = "Win32 sous Windows 95/98";
        public static string ksc_sysinfo11 = "Non d�tect�e";
        public static string ksc_sysinfo18 = "Non d�tect�";
        public static string ksc_sysinfo23 = "Oui";
        public static string ksc_sysinfo24 = "Non";
        public static string ksc_sysinfo28 = "Non Connect�";
        public static string ksc_sysinfo29 = "Pas de r�seau";
        public static string ksc_sysinfo30 = "Erreur r�seau";
        public static string ksc_sysinfo34 = "[ PARAMETRES WINDOWS ]";
        public static string ksc_sysinfo35 = "Nom de l'ordinateur : ";
        public static string ksc_sysinfo36 = "Syst�me : %s";
        public static string ksc_sysinfo37 = "Version %s";
        public static string ksc_sysinfo38 = "Num�ro de licence : ";
        public static string ksc_sysinfo39 = "Nom de l'utilisateur : ";
        public static string ksc_sysinfo40 = "Nom de la compagnie : ";
        public static string ksc_sysinfo41 = "Nom r�seau : ";
        public static string ksc_sysinfo42 = "[ PARAMETRES DISQUE ]";
        public static string ksc_sysinfo43 = "Disque actif : ";
        public static string ksc_sysinfo44 = "S�rie : ";
        public static string ksc_sysinfo45 = "Type de syst�me : ";
        public static string ksc_sysinfo46 = "Lecteurs : ";
        public static string ksc_sysinfo47 = "R�pertoire actif : ";
        public static string ksc_sysinfo48 = "R�pertoire syst�me : ";
        public static string ksc_sysinfo49 = "R�pertoire Windows : ";
        public static string ksc_sysinfo50 = "Secteurs par piste : %.0n";
        public static string ksc_sysinfo51 = "Taille secteurs : %.0n";
        public static string ksc_sysinfo52 = "Pistes disponibles : %.0n";
        public static string ksc_sysinfo53 = "Total Pistes : %.0n";
        public static string ksc_sysinfo54 = "Total disque : %.0n octets";
        public static string ksc_sysinfo55 = "Espace disponible : %.0n octets";
        public static string ksc_sysinfo56 = "[ PARAMETRES PROCESSEUR ]";
        public static string ksc_sysinfo58 = "Nombre de micro-processeurs : %d";
        public static string ksc_sysinfo59 = "Type de micro-processeur";

        //--[.designer.cs]--------------- sysinfo -----------------------------------------------

        public static string DialSysInfoText = "Informations Syst�me";
        public static string DialSysInfoToolTip = "Affichage des informations Syst�me";
        public static string berreurslogToolTip = "Affichage du fichier ERREURS.LOG";
        public static string berreurslogText = "&Journal";
        public static string bexporteToolTip = "Export des informations pour assistance";
        public static string bexporteText = "&Exporte";
        public static string bConfigurationToolTip = "Acc�s au panneau de configuration";
        public static string bConfigurationText = "&Panneau";
        public static string bsyseditToolTip = "Lancement de SysEdit";
        public static string bsyseditText = "&SysEdit";
        public static string bregeditToolTip = "Lancement de RegEdit";
        public static string bregeditText = "&RegEdit";
        public static string rbHTMLToolTip = "Export HTML";
        public static string rbHTMLText = ".HTML";
        public static string rbCSVToolTip = "Export format d�limit�";
        public static string rbCSVText = ".CSV";
        public static string rbpressepapierToolTip = "Vers le presse-papier";
        public static string rbpressepapierText = "Presse-papier";

        //--[.cs]---------------------- astuce ------------------------------------------------

        public static string ksCleAstuces = "ASTUCES";
        public static string ksc_astuce01 = "Pas d'astuce du jour. Contr�ler le fichier des astuces (ASTUCES.TXT).";

        //--[.designer.cs]--------------- astuce ------------------------------------------------

        public static string DialogueAstuceToolTip = "Conseil d'utilisation ; utilisez [S] pour afficher l'astuce suivante";
        public static string lNotreConseilText = "Notre conseil...";
        public static string cbAstuceDuJourText = "&Afficher au lancement :";
        public static string cbAstuceDuJourToolTip = "Ne plus afficher les astuces|L'�cran d'affichage des astuces peut �tre d�sactiv� en d�cochant cette case";
        public static string bContinuerToolTip = "Fermer l'astuce et continuer";
        public static string bContinuerText = "&Continuer >>";
        public static string bAstuceSuivanteToolTip = "Passer � l'astuce suivante";
        public static string bAstuceSuivanteText = "Autre a&stuce";
        public static string bPresentationToolTip = "Pr�sentation de CADET";
        public static string bPresentationText = "&Pr�sentation";
        public static string bMisesAJourToolTip = "Am�liorations/Corrections du logiciel";
        public static string bMisesAJourText = "&Mises � jour";

        //--[.designer.cs]--------------- splash_CADET --------------------------------------------

        public static string pAProposToolTip = "Fen�tre d'information sur CADET";
        public static string DescriptionText = "Comptabilit� pour Association d'Etudiants";
        public static string AdresseText = "xxx" + CRLF + "F-xxx xxx (FRANCE)" + CRLF + "T�l. : +33 (0)xxxx" + CRLF + "Fax : +33 (0) xxxx";
        public static string bEnregistrementText = "&Enregistrement";
        public static string bEnregistrementToolTip = "Comment s'enregistrer ?";
        public static string CommentsText = "Ce logiciel est distribu� xxxx. Simple, rapide, ouvert" +
            ", utile et agr�able, il vous est fourni complet et sans limitation " +
            "pour son �valuation. Vous �tes encourag�(e) � copier librement " +
            "l'ensemble du programme � d'autres utilisateurs.";
        public static string llAdresseWebToolTip = "Acc�dez directement au site du logiciel";

        //--[.cs]---------------------- Apropo ------------------------------------------------

        public static string ksC_Apropo01 = "<<BETA>>";
        public static string ksC_Apropo02 = "Vous utilisez CADET depuis %s jours.";

        //--[.designer.cs]--------------- Apropo ------------------------------------------------

        public static string DialAProposCADETText = "A propos de CADET pour Windows";
        public static string CommentsAPText = "L'enregistrement vous permet de recevoir la derni�re version " +
            "disponible et de b�n�ficier du support Technique.  ";
        public static string lbUtilisateurText = "** Version non enregistr�e **";
        public static string lUtilisateurText = "Utilisateur :";
        public static string btEnregistrementToolTip = "Saisie du num�ro d'enregistrement";
        public static string btContinuerToolTip = "Ecran principal de CADET";
        public static string btContinuerText = "Con&tinuer >>";

        //--[.cs]---------------------- Enreg -------------------------------------------------

        public static string ksC_Enreg01 = "Informations d'enregistrement correctes.";
        public static string ksC_Enreg02 = "Vous �tes � pr�sent un utilisateur enregistr�.";
        public static string ksC_Enreg04 = "Vous �tes � pr�sent une utilisatrice enregistr�e.";
        public static string ksC_Enreg03 = "Informations d'enregistrement incorrectes.";

        //--[.designer.cs]--------------- Enreg -------------------------------------------------

        public static string DialogueEnregistrementToolTip =
            "Enregistrement de CADET pour Windows ; [F1] pour plus d'informations";
        public static string DialogueEnregistrementText = "Enregistrement de CADET pour Windows";
        public static string lbNomText = "&Utilisateur :";
        public static string Label2Text = "&Code :";
        public static string sNomUtilisateurToolTip = "Entrer le nom figurant sur votre enregistrement";
        public static string sCodeEnregistrementToolTip = "Entrer le code utilisateur";
        public static string bOKEnregistreUtilisateurToolTip = "Enregistrer la licence";
        public static string bOKEnregistreUtilisateurText = "&Enregistrer";

        //--[.cs]---------------------- memo --------------------------------------------------

        public static string ksc_memo01 = "Lignes";
        public static string ksc_memo02 = "Date Memo";
        public static string ksc_memo03 = "Affichage d'un �v�nement m�moris�";

        //--[.designer.cs]--------------- memo --------------------------------------------------

        public static string DialMemoToolTip = "Saisie d'un �v�nement � m�moriser";
        public static string DialMemoText = "M�mo";
        public static string lDateMemoText = "&Date :";
        public static string lNbLignesMemoText = "Nombre de lignes : ";
        public static string bEnregistreToolTip = "Enregistrement du message";
        public static string bEnregistreText = "&Enregistre";
        public static string eDateMemoToolTip = "Date du message";
        public static string cbSupprimerMessageMemoToolTip = "Cliquer cette case pour supprimer le message";
        public static string cbSupprimerMessageMemoText = "&Suppression du message";

        // :FIN
        // ============================================================
    }
}






