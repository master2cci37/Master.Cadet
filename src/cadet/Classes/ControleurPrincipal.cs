using System;
using System.Collections.Generic;
using System.Text;

namespace CADET
{

    /// <summary>
    /// Controleur de l'application CADET
    /// </summary>
    partial class FormCADETPrincipal
    {
        #region initialisation au chargement
        /// <summary>
        /// initialisation au chargement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCADETPrincipal_Load(object sender, EventArgs e)
        {
            this.fichierToolStripMenuItem.ToolTipText = "Ouverture d'un dossier comptable";
            this.quitterToolStripMenuItem.ToolTipText = "Quitter l'application";
        }
        #endregion

        // =========================================================================
        // Menu Fichier 
        // =========================================================================
        /// <summary>
        /// Cr�ation d'un nouveau dossier comptable. Assistant de cr�ation du premier exercice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormNouveau formNouveau = new FormNouveau();
            formNouveau.ShowDialog();
        }

        /// <summary>
        /// Ouverture d'un dossier existant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void toolStripMenuItemOuvrir_Click(object sender, EventArgs e)
        {
            FormOuvrir formOuvrir = new FormOuvrir();
            formOuvrir.ShowDialog();
        }

        /// <summary>
        /// Sauvegarde votre comptabilit�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void sauvegardeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSauvegarde formSauvegarde = new FormSauvegarde();
            formSauvegarde.ShowDialog();
        }

        /// <summary>
        /// Reprend vos fichiers comptables sauvegard�s
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void restaurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRestauration formRestauration = new FormRestauration();
            formRestauration.ShowDialog();
        }

        /// <summary>
        /// Modifie les �l�ments du dossier et l'environnement de travail de CADET, export XML complet.  
        /// Suppression d'un dossier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void parametresDossierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormParametreDossier formParametreDossier = new FormParametreDossier();
            formParametreDossier.ShowDialog();
        }

        /// <summary>
        ///Param�tres des utilisateurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void utilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUtilisateurs formUtilisateurs = new FormUtilisateurs();
            formUtilisateurs.ShowDialog();
        }

        /// <summary>
        /// La gestion de la TVA sera pr�vue dans la base de donn�es
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void gestionTVAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionTVA formGestionTVA = new FormGestionTVA();
            formGestionTVA.ShowDialog();
        }

        /// <summary>
        /// Permet de param�trer les taux de conversion des devises
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void devisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDevises formDevises = new FormDevises();
            formDevises.ShowDialog();
        }

        /// <summary>
        /// Modifie l'affichage de CADET
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void affichageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAffichage formAffichage = new FormAffichage();
            formAffichage.ShowDialog();
        }

        /// <summary>
        ///Contr�le du param�trage de l'impression
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void imprimanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormImprimante formImprimante = new FormImprimante();
            formImprimante.ShowDialog();
        }

        /// <summary>
        ///Param�tre des avertissements Sonores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void sonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSon formSon = new FormSon();
            formSon.ShowDialog();
        }

        /// <summary>
        ///??a supprimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            FormSon formImprimante = new FormSon();
            formImprimante.ShowDialog();
        }

        /// <summary>
        ///Lance l'exporateur des dossiers comptables, par d�faut
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void explorateurEditeFichierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExplorateur formExplorateur = new FormExplorateur();
            formExplorateur.ShowDialog();
        }

        /// <summary>
        ///Edition d'un nouveau fichier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void editeUnFichierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditeFichier formEditeUnFichier = new FormEditeFichier();
            formEditeUnFichier.ShowDialog();
        }

        /// <summary>
        /// Lance l'�dition du fichier choisi avec l'�diteur par d�faut
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        #region quitter l'application
        /// <summary>
        /// Quitte d�finitivement CADET
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO : verifier si la sauvegarde est recente et demander confirmation sinon
            Close();
        }

        #endregion

        // =========================================================================
        // Menu Creation
        // =========================================================================

        /// <summary>
        /// Saisie des �critures comptables dans les journaux
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void saiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSaisieEcritures formSaisieEcritures = new FormSaisieEcritures();
            formSaisieEcritures.ShowDialog();

        }

        /// <summary>
        /// Saisie rapide des d�caissement/encaissements
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void recettesDepensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRecettesDepenses formRecettesDepenses = new FormRecettesDepenses();
            formRecettesDepenses.ShowDialog();

        }

        /// <summary>
        /// Import des �critures et comptes au format XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void importationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormImportation formImportation = new FormImportation();
            formImportation.ShowDialog();
        }

        /// <summary>
        /// Cr�ation de mod�les  / sauvegardes au format XML 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void abonnementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbonnement formAbonnement = new FormAbonnement();
            formAbonnement.ShowDialog();
        }

        /// <summary>
        /// export des �critures XML/CSV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void exporteEcritureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExporteEcritures formExporteEcritures = new FormExporteEcritures();
            formExporteEcritures.ShowDialog();
        }

        /// <summary>
        /// Cr�ation/Modifications/Supression d'un journal avec choix de la p�riode le cas �ch�ant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void jaurnauxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormJournaux formJournaux = new FormJournaux();
            formJournaux.ShowDialog();
        }

        /// <summary>
        /// Cr�e/ modifier les activit�s du dossier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void activitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormActivites formActivites = new FormActivites();
            formActivites.ShowDialog();
        }

        /// <summary>
        /// Cr�e les comptes individuellement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void creationManuelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreationManuelle formCreationManuelle = new FormCreationManuelle();
            formCreationManuelle.ShowDialog();
        }

        /// <summary>
        /// Ou par importation d'un fichier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void importationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormImportations formImportations = new FormImportations();
            formImportations.ShowDialog();
        }

        /// <summary>
        /// G�stion des �l�ments du patrimoinne
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void elementPatrimoineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormElementsPatrimoine formElementsPatrimoine = new FormElementsPatrimoine();
            formElementsPatrimoine.ShowDialog();
        }


        // =========================================================================
        // Menu Edition
        // =========================================================================

        /// <summary>
        /// Journaux (*) avec analytique
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void journauxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormJournaux formJournaux = new FormJournaux();
            formJournaux.ShowDialog();
        }

        /// <summary>
        /// Edite le r�capitulatif de tous les journaux
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void centralisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCentraliseur formCentraliseur = new FormCentraliseur();
            formCentraliseur.ShowDialog();
        }

        /// <summary>
        /// Grand-livre (g�n�ral et tiers)(*) avec analytique. Avec possibilit� d'affichage des comptes � l'�cran pour lettrage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void grandLivreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGrandesClasses formGrandesClasses = new FormGrandesClasses();
            formGrandesClasses.ShowDialog();
        }

        /// <summary>
        ///   Balance (g�n�rale et tiers) pour une p�riode donn�e
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void balanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBalance formBalance = new FormBalance();
            formBalance.ShowDialog();
        }

        /// <summary>
        ///     Recherche d'une �criture dans la comptabilit�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void rechercheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRecherche formRecherche = new FormRecherche();
            formRecherche.ShowDialog();
        }

        /// <summary>
        ///     Edition des param�tres du dossier en cours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void dossierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDossier formDossier = new FormDossier();
            formDossier.ShowDialog();
        }

        /// <summary>
        ///     Edition du plan comptable avec options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void planComptableToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormPlanComptable formPlanComptable = new FormPlanComptable();
            formPlanComptable.ShowDialog();
        }

        /// <summary>
        ///    Etat d'inventaire des �l�ments du patrimoine  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void inventairePatrimoineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInventairePatrimoine formInventairePatrimoine = new FormInventairePatrimoine();
            formInventairePatrimoine.ShowDialog();
        }


        // =========================================================================
        // Menu Options
        // =========================================================================
        /// <summary>
        /// G�n�re le bilan d�taill� du dossier en cours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bilanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBilan formBilan = new FormBilan();
            formBilan.ShowDialog();
        }

        /// <summary>
        /// Compte de r�sultat (*) avec analytique. Propose le Compte de R�sultat d�taill� de cette Comptabilit�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void compteResultatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCompteResultat formCompteResultat = new FormCompteResultat();
            formCompteResultat.ShowDialog();
        }

        /// <summary>
        /// Donne les grandes classes de cette comptabilit�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void grandClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGrandesClasses formGrandesClasses = new FormGrandesClasses();
            formGrandesClasses.ShowDialog();
        }

        /// <summary>
        /// Cr�e un tableau de bord annuel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void balanceAnnuelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBalanceAnnuelle formBalanceAnnuelle = new FormBalanceAnnuelle();
            formBalanceAnnuelle.ShowDialog();
        }
        /// <summary>
        /// Edition du contr�le budg�taire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void controleBudgetaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormControleBudgetaires formControleBudgetaires = new FormControleBudgetaires();
            formControleBudgetaires.ShowDialog();
        }

        /// <summary>
        /// Cr�e les �tats r�capitulatifs de votre comptabilit�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        private void lettrageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLettrage formLettrage = new FormLettrage();
            formLettrage.ShowDialog();
        }

        /// <summary>
        /// Retire tous les pointages port�s sur un compte.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 

        private void delettrageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDelettrage formDelettrage = new FormDelettrage();
            formDelettrage.ShowDialog();
        }


        /// <summary>
        /// Met � jour vos comptes depuis la derni�re mise � jour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void depointageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDepointage formDepointage = new FormDepointage();
            formDepointage.ShowDialog();
        }

        /// <summary>
        /// Reconstruit la base de donn�es du dossier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void regenerationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegeneration formRegeneration = new FormRegeneration();
            formRegeneration.ShowDialog();
        }

        /// <summary>
        /// Arr�t� mensuel, par journal. Rend impossibles les saisies ou/et modifications ult�rieures sur un mois
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void arreteMensuelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormArreteMensuel formArreteMensuel = new FormArreteMensuel();
            formArreteMensuel.ShowDialog();
        }

        /// <summary>
        /// Cloture annuelle d un dossier comptable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void arreteAnnuelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClotureAnnuelle formClotureAnnuelle = new FormClotureAnnuelle();
            formClotureAnnuelle.ShowDialog();
        }

        /// <summary>
        ///    Donne les mouvements d'un compte par mois sur l'exercice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mouvementsComptesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMouvementsComptes formMouvementsComptes = new FormMouvementsComptes();
            formMouvementsComptes.ShowDialog();
        }

        /// <summary>
        ///    Affiche mensuellement un �tat de votre tr�sorerie 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void tresorerieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTresorerie formTresorerie = new FormTresorerie();
            formTresorerie.ShowDialog();
        }

        /// <summary>
        ///  Pr�paration du Rapprochement bancaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void rapprochementBancaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRapprochementBancaire formRapprochementBancaire = new FormRapprochementBancaire();
            formRapprochementBancaire.ShowDialog();
        }

        /// <summary>
        /// saisie des �lements budg�taires
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void budgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBudget formBudget = new FormBudget();
            formBudget.ShowDialog();
        }

        // =========================================================================
        // Menu Outils
        // =========================================================================

        /// <summary>
        ///   Outils  externes au logiciel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void libreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        ///   Petite calculatrice 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void CalculatriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCalculatrice formCalculatrice = new FormCalculatrice();
            formCalculatrice.ShowDialog();
        }

        /// <summary>
        ///      Calendrier / agenda avec affichage lors de l'accueil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgenda formAgenda = new FormAgenda();
            formAgenda.ShowDialog();
        }

        /// <summary>
        ///     Param�trage du menu outils    
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void assistToolStripMenuItem_Click(object sender, EventArgs e)
        {


            FormOutilsSupplementaires formOutilsSupplementaires = new FormOutilsSupplementaires();
            formOutilsSupplementaires.ShowDialog();
        }


        // =========================================================================
        // Menu Aide
        // =========================================================================       
        /// <summary>
        ///    
        /// Appel de l'aide contextuelle sur le choix en cours/summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void contenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormContenu formContenu = new FormContenu();
            formContenu.ShowDialog();
        }

        /// <summary>
        ///  Aide sur le fonctionnement du syst�me d'aide  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void aideSurAideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAideAide formAideAide = new FormAideAide();
            formAideAide.ShowDialog();
        }

        /// <summary>
        ///  Comment bien d�marrer sur CADET
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void premiersPasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPremiersPas formPremiersPas = new FormPremiersPas();
            formPremiersPas.ShowDialog();
        }

        /// <summary>
        ///    Envoyer un courrier �lecronique pour obtenir de l'assistance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void assistanceTechniqueToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormAssitanceTechnique formAssitanceTechnique = new FormAssitanceTechnique();
            formAssitanceTechnique.ShowDialog();
        }

        /// <summary>
        ///   Acc�s au site internet du programme pour plus d'informations et actualit�s 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void siteWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSiteWeb formSiteWeb = new FormSiteWeb();
            formSiteWeb.ShowDialog();
        }

        /// <summary>
        /// Version du programme et informations compl�mentaires
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormApropos formApropos = new FormApropos();
            formApropos.ShowDialog();
        }

        /// <summary>
        ///  Saisie des informations d'enregistrement de la licence de CADET
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void enregistrementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEnregistrement formEnregistrement = new FormEnregistrement();
            formEnregistrement.ShowDialog();
        }
    }
}
