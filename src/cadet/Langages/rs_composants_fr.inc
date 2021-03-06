(* ==========================================================================
 Nom de classe : rs_composants_fr.inc�
 Info Version  :  boutons, label, hint, menus francais
 Copyright : 01/2008 Master 2 CCI /  UFRT / UE1 Professeur :  M.  DI SCALA
 Auteur(s) : Mehdi ALLAS, JF. PACORY, Mahmoud BOUKERROUI
 Etat :   Version initiale
 --------------------------------------------------------------------------
 R�vision(s) :
 ========================================================================== *)
// toolButton panneau gauche
// ============================================================
ToolButtonAnimation.Caption                      := '&Animation';
ToolButtonAnimation.Hint                         := 'Page d''animation du programme principal|Page d''animation, permet d''ex�cuter un programme MAP (.exec)';
ToolButtonApropos.Caption                        := 'A &propos';
ToolButtonApropos.Hint                           := 'A propos|Afficher des informations � propos de cette application, auteurs et version';
ToolButtonCodeDASM.Caption                       := '&D�sassemble';
ToolButtonCodeDASM.Hint                          := 'D�sassemble|D�sassemblage des fichiers gener�s apr�s lancement du programme';
ToolButtonDocumentation.Caption                  := '&Documentation';
ToolButtonDocumentation.Hint                     := 'Documentation utilisateur|Afficher la documentation de l''application';
ToolButtonExecutable. Caption                    := '&Ex�cutable';
ToolButtonExecutable. Hint                       := 'Ex�cutable|Fichier ex�cutable';
ToolButtonFichierXML.Caption                     := 'Fichier &XML';
ToolButtonFichierXML.Hint                        := 'Fichier XML|Fichier code au format XML';
ToolButtonPresentation.Caption                   := '&Pr�sentation';
ToolButtonPresentation.Hint                      := 'Pr�sentation|Pr�sentation du programme.';
ToolButtonRapport.Caption                        := '&Rapport';
ToolButtonRapport.Hint                           := 'Rapport|Fichier code au format texte';
ToolButtonSaisie.Caption                         := '&Saisie';
ToolButtonSaisie.Hint                            := 'Saisie d''une expression|Saisie d''une expression arithm�tique, traduction en post-fix� et g�n�ration des fichiers sources et programme';
// ============================================================
// menus d�roulants
// ============================================================
// ------------------------------------------------------------
// Fichier
// ------------------------------------------------------------
MenuItemEnregistrer.Caption                      := '&Enregistrer sous';
MenuItemEnregistrer.Hint                         := 'Enregistrer un fichier ex�cutable sous un autre nom pour utilisation ult�rieure';
MenuItemFichier.Caption                          := '&Fichier';
MenuItemFichier.Hint                             := '';        
MenuItemOuvrir. Caption                          := '&Ouvrir';
menuitemOuvrir.Hint                              :=  'Ouvrir un fichier ex�cutable MAP (.exec) et lancer l''animation';
MenuItemQuitter.Caption                          := '&Quitter';
menuItemQuitter.Hint                             := 'Quitter l''application';
// ------------------------------------------------------------
// menu edition
// ------------------------------------------------------------
MenuItemColler.Caption                           := '&Coller';
MenuItemColler.Hint                              := 'Coller une expression depuis le presse papier';
MenuItemCopier.Caption                           := '&Copier';
MenuItemCopier.Hint                              := 'Copier une expression vers le presse papier';
MenuItemCouper.Caption                           := '&Couper';
MenuItemCouper.Hint                              := 'Couper une expression vers le presse papier';
MenuItemEdition.Caption                          := '&Edition';
MenuItemEdition.Hint                             := '';
// ------------------------------------------------------------
// Traitements
// ------------------------------------------------------------
menuItemAnimation. Caption                       := '&Animation';
menuItemCodeSource.Caption                       := '&Code source';
menuItemExecutable.Caption                       := '&Ex�cutable';
menuItemExportXML.Caption                        := 'Export &XML';
menuItemPresentation.Caption                     := '&Pr�sentation';
menuItemRapport.Caption                          := '&Rapport d''ex�cution';
menuItemSaisie.Caption                           := '&Saisie';
menuitemTraitements.Caption                      := '&Traitements';
menuitemTraitements.Hint                         := '';
menuItemVisualisations.Caption                   := '&Visualisations';
menuItemVisualisations.Hint                      := '';
menuItemXMLfeuillestyles.Caption                 := 'XML et feuille de &styles';
menuItemXMLfeuillestyles.Hint                    := 'Explorer avec feuille de styles|Affiche le pr�sent fichier avec une feuille de styles (XSLT)';
MenuItemAnimation.Hint :=  ToolButtonAnimation.Hint ;
MenuItemCodesource.Hint := ToolButtonCodeDASM.Hint ;
MenuItemExecutable.Hint := ToolButtonExecutable. Hint ;
MenuItemExportXML.Hint := ToolButtonFichierXML.Hint ;
MenuItemPresentation.Hint := ToolButtonPresentation.Hint ;
MenuItemRapport.Hint := ToolButtonRapport.Hint ;
MenuItemSaisie.Hint :=  ToolButtonSaisie.Hint ;
// ------------------------------------------------------------
// Affichage
// ------------------------------------------------------------
MenuItemAffichage.Caption                        := 'A&ffichage';
MenuItemAffichage.Hint                           := '';
MenuItemBarredeboutonsGauche.Caption             := 'Barre de boutons � &gauche';
MenuItemBarredeboutonsGauche.Hint                := 'Afficher la barre d''outils � droite et vice versa';
menuItemBarredesstatuts.Caption                  := 'Barre des &statuts';
menuItemBarredesstatuts.Hint                     := 'Afficher ou masquer la barre des statuts';
menuItemBarredoutils.Caption                     := '&Barre de boutons';
menuItemBarredoutils.Hint                        := 'Afficher ou masquer la barre d''outils';
menuItemCouleurspanneaux.Caption                 := '&Couleurs panneaux ...';
menuItemCouleurspanneaux.Hint                    := 'Choisir la couleur de fond d''�cran';
MenuItemInterfaceanglaise.Caption                := 'Interface en anglais';
MenuItemInterfaceanglaise.Hint                   := 'Afficher l''interface en langue anglaise';
menuItemPleinEcran.Caption                       := '&Plein �cran';
menuItemPleinEcran.Hint                          := 'Mettre l''application en plein �cran ou restaurer � la taille initiale';
// ------------------------------------------------------------
// menu aide
// ------------------------------------------------------------
MenuItemAide.Caption                             := '&Aide';
MenuItemAide.Hint                                := '';
menuItemAideAppli.Caption                        := '&Aide';
menuItemAideappli.Hint                           := 'Afficher l''aide en ligne de l''application';
menuItemApropos.Caption                          := 'A &propos';
menuItemDocumentation.Caption                    := '&Documentation';
MenuItemDocumentation.Hint :=  ToolButtonDocumentation.Hint;
MenuItemAPropos.Hint := ToolButtonApropos.Hint ;
// ------------------------------------------------------------
// barre des statuts
// ------------------------------------------------------------
statusbarVue.Hint                                := 'Information sur les composants de l''interface';
StatusBarVue.panels[1].Text := sPret;
// ============================================================
// pages du tNoteBook
// ============================================================
// titres des pages
// ------------------------------------------------------------
sp0titre                                         := 'Pr�sentation du programme';
sp1titre                                         := 'Saisie de l''expression arithm�tique';
sp2titre                                         := 'Rapport de compilation';
sp3titre                                         := 'Contenu du fichier ex�cutable';
sp4titre                                         := 'Contenu du fichier XML';
sp5titre                                         := 'D�tail du d�sassemblage des fichiers g�n�r�s';
sp6titre                                         := 'Animation du programme';
sp7titre                                         := 'Documentation utilisateur';
sp8titre                                         := 'A propos ...';
// ------------------------------------------------------------
// chaine diverses
// ------------------------------------------------------------
sExecutionDuFichier                              := 'Ex�cution du fichier : ';
sAttentionSaisie09                               := 'Vous devez saisir des valeurs comprises entre 0 et 9 pour chacune des variables n�cessaires � l''ex�cution de la machine MAP.';
sSaisieDesVariables                              := 'Saisie des variables';
sBienvenue                                       := 'Bienvenue dans l''application ';
sHintParDefaut                                   := 'Appuyez sur F1 pour obtenir de l''aide';
sPret                                            := 'Pr�t';
sOccupe                                          := 'Occup�';
sFormatDateHeure                                 := 'dd/mm/yyyy hh:nn';
sChargementDunProgrammeExecutable                := 'Chargement d''un programme ex�cutable';
sSauvegardeDunProgrammeExecutable                := 'Sauvegarde d''un programme ex�cutable';
sFichierAideIntrouvable                          := 'Le fichier d''aide est introuvable !';
sOpenDialogueFichiersExecutablesFilter           := 'Fichiers ex�cutables|*.exec|Tous les fichiers|*.*|Fichiers texte|*.txt|Fichiers XML|*.xml';
// ------------------------------------------------------------
// page presentation
// ------------------------------------------------------------
ButtonAccueilDoc.caption                         := '&Pr�c�dent';
ButtonAccueilDoc.Hint                            := 'Page pr�c�dente|Affiche la derni�re page vue dans l''explorateur';
// ------------------------------------------------------------
// page saisie
// ------------------------------------------------------------
ButtonEffacer.caption                            := '&CE';
ButtonEffacer.Hint                               := 'Effacer|Effacer toutes les zones d''affichage.';
ButtonGenerAutExprArithm.caption                 := '&G�n�rer automatiquement une expression arithm�tique';
ButtonGenerAutExprArithm.Hint                    := 'G�n�rer|Gen�re automatiquement une expression arithm�tique';
ButtonRetour.caption                             := '&Retour';
ButtonRetour.Hint                                := 'Retour|Effacer le dernier caract�re saisie dans l''�cran';
ButtonTradPostFix.caption                        := '&Traduire en postfix� et g�n�rer code et ex�cutable' ;
ButtonTradPostFix.Hint                           := 'Traduction|Traduction de l''expression arithm�tique en postfix� ; G�neration de deux fichiers (code et ex�cutable)';
PanelCopiecalc.Hint                              := 'Zone d''affichage de la traduction de l''expression arithm�tique';
PanelSaisieCalc.Hint                             := 'Zone de saisie de l''expression arithm�tique';
MemoAide1lines                                   := 'L''utilisateur saisit manuellement et '+
                                                    'directement une expression '+
                                                    'arithm�tique dans la premi�re zone, ou en '+
                                                    'utilisant le pav� alphanum�rique : en '+
                                                    'cliquant sur une touche le contenu de '+
                                                    ' cette derni�re s''affiche '+
                                                    'automatiquement.';
MemoAide2lines                                   := 'Cliquer sur le bouton"G�n�rer..." '+
                                                    'et le programme '+
                                                    'traduira automatiquement '+
                                                    'l''expression arithm�tique saisie et ' +
                                                    'l''affichera dans le champ suivant '+
                                                    'en version post-fix�e';
// ------------------------------------------------------------
// page rapport
// ------------------------------------------------------------
// n�ant
// ------------------------------------------------------------
// page executable
// ------------------------------------------------------------
// n�ant
// ------------------------------------------------------------
// page xml
// ------------------------------------------------------------
ButtonVisuXMLStyle.caption                       := 'Avec Feuille de &styles (XSLT)';
ButtonVisuXMLStyle.Hint := menuItemXMLfeuillestyles.Hint;
// ------------------------------------------------------------
// page desassemblage
// ------------------------------------------------------------
editDesassemblage.text                           := 'Code ex�cutable';
editExecutable.text                              := 'Code d�sassembl�';
// ------------------------------------------------------------
// page animation  + erreurs machineMAP
// ------------------------------------------------------------
BitBtJoueExec.Caption                            := '';
BitBtJoueExec.hint                               := 'Joue|Lance l''ex�cution sur le code du fichier s�lectionn�';
BitBtnArreteExec.Caption                         := '';
BitBtnArreteExec.hint                            := 'Stop|Arr�te l''animation et la replace � son point de d�part';
BitBtnOuvreExec.Caption                          := '';
BitBtnOuvreExec.hint                             := 'Ouvrir|Ouvre un fichier ex�cutable (.exec) pour l''animer';
BitBtnPauseExec.Caption                          := '';
BitBtnPauseExec.hint                             := 'Pause|Arr�te momentan�ment l''animation';
GroupBoxOperande1.Caption                        := ' Op�rande 1 ';
GroupBoxOperande1.hint                           := 'Op�rande n�1|Registre op�rande n�1';
GroupBoxOperande2.Caption                        := ' Op�rande 2 ';
GroupBoxOperande2.hint                           := 'Op�rande n�2|Registre op�rande n�2';
GroupBoxResultat.Caption                         := ' R�sultat ';
GroupBoxResultat.hint                            := 'Accumulateur|Accumulateur de la machine';
GroupBoxVariables.Caption                        := ' Variables ';
LabelLent.Caption                                := 'Lent';
LabelNomFichier.Caption                          := 'Sous-titre';
LabelRapide.Caption                              := 'Rapide';
LabelTitreCode.Caption                           := 'CODE ()';
ListBoxCode.hint                                 := 'Instructions|Liste des instructions charg�es pr�tes pour l''ex�cution';
ListBoxPileLIFOAnimation.Hint                    := 'Pile|Pile d''ex�cution de la machine � pile';
StringGridVariablesAnimation.hint                := 'Table des symboles|Table des symboles (entrez des valeurs entre 0 et 9)';
TrackBarAnimation.hint                           := 'Variateur|Variation de la vitesse de l''animation';
// -- Dans machineMAP -----------------------------------------
sDivisionParZero                                 := 'Division par z�ro impossible ; rectifiez vos variables.';
sErreurCodeIncorrect                             := 'Erreur uclasseMachineMAP : num�ro de code incorrect';
// ------------------------------------------------------------
// page documentation
// ------------------------------------------------------------
//n�ant
// ------------------------------------------------------------
// page a propos
// ------------------------------------------------------------
sVersionProgramme                                := 'VERSION DU PROGRAMME';
sLabelNumeroConstruction                         := 'Construction';
sLabelDateCompilation                            := 'Date compilation : ';
sLabelAuteurs                                    := 'AUTEURS';
sLabelClassesMetiers                             := 'Classes m�tiers';
sLabelEquipeDevt                                 := 'Equipe d�veloppement agile';
sLabelEquipeConception                           := 'Conception IHM, tests, documentation';
sLabelInstallateur                               := 'INSTALLATEUR';
sLabelInformationsWindows                        := 'INFORMATIONS SYSTEME WINDOWS';
sLabelCliquerici                                 := 'Cliquez ici';
// :FIN
// ============================================================
