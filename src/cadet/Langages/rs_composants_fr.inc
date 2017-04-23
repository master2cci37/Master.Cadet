(* ==========================================================================
 Nom de classe : rs_composants_fr.inc²
 Info Version  :  boutons, label, hint, menus francais
 Copyright : 01/2008 Master 2 CCI /  UFRT / UE1 Professeur :  M.  DI SCALA
 Auteur(s) : Mehdi ALLAS, JF. PACORY, Mahmoud BOUKERROUI
 Etat :   Version initiale
 --------------------------------------------------------------------------
 Révision(s) :
 ========================================================================== *)
// toolButton panneau gauche
// ============================================================
ToolButtonAnimation.Caption                      := '&Animation';
ToolButtonAnimation.Hint                         := 'Page d''animation du programme principal|Page d''animation, permet d''exécuter un programme MAP (.exec)';
ToolButtonApropos.Caption                        := 'A &propos';
ToolButtonApropos.Hint                           := 'A propos|Afficher des informations à propos de cette application, auteurs et version';
ToolButtonCodeDASM.Caption                       := '&Désassemble';
ToolButtonCodeDASM.Hint                          := 'Désassemble|Désassemblage des fichiers generés après lancement du programme';
ToolButtonDocumentation.Caption                  := '&Documentation';
ToolButtonDocumentation.Hint                     := 'Documentation utilisateur|Afficher la documentation de l''application';
ToolButtonExecutable. Caption                    := '&Exécutable';
ToolButtonExecutable. Hint                       := 'Exécutable|Fichier exécutable';
ToolButtonFichierXML.Caption                     := 'Fichier &XML';
ToolButtonFichierXML.Hint                        := 'Fichier XML|Fichier code au format XML';
ToolButtonPresentation.Caption                   := '&Présentation';
ToolButtonPresentation.Hint                      := 'Présentation|Présentation du programme.';
ToolButtonRapport.Caption                        := '&Rapport';
ToolButtonRapport.Hint                           := 'Rapport|Fichier code au format texte';
ToolButtonSaisie.Caption                         := '&Saisie';
ToolButtonSaisie.Hint                            := 'Saisie d''une expression|Saisie d''une expression arithmétique, traduction en post-fixé et génération des fichiers sources et programme';
// ============================================================
// menus déroulants
// ============================================================
// ------------------------------------------------------------
// Fichier
// ------------------------------------------------------------
MenuItemEnregistrer.Caption                      := '&Enregistrer sous';
MenuItemEnregistrer.Hint                         := 'Enregistrer un fichier exécutable sous un autre nom pour utilisation ultérieure';
MenuItemFichier.Caption                          := '&Fichier';
MenuItemFichier.Hint                             := '';        
MenuItemOuvrir. Caption                          := '&Ouvrir';
menuitemOuvrir.Hint                              :=  'Ouvrir un fichier exécutable MAP (.exec) et lancer l''animation';
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
menuItemExecutable.Caption                       := '&Exécutable';
menuItemExportXML.Caption                        := 'Export &XML';
menuItemPresentation.Caption                     := '&Présentation';
menuItemRapport.Caption                          := '&Rapport d''exécution';
menuItemSaisie.Caption                           := '&Saisie';
menuitemTraitements.Caption                      := '&Traitements';
menuitemTraitements.Hint                         := '';
menuItemVisualisations.Caption                   := '&Visualisations';
menuItemVisualisations.Hint                      := '';
menuItemXMLfeuillestyles.Caption                 := 'XML et feuille de &styles';
menuItemXMLfeuillestyles.Hint                    := 'Explorer avec feuille de styles|Affiche le présent fichier avec une feuille de styles (XSLT)';
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
MenuItemBarredeboutonsGauche.Caption             := 'Barre de boutons à &gauche';
MenuItemBarredeboutonsGauche.Hint                := 'Afficher la barre d''outils à droite et vice versa';
menuItemBarredesstatuts.Caption                  := 'Barre des &statuts';
menuItemBarredesstatuts.Hint                     := 'Afficher ou masquer la barre des statuts';
menuItemBarredoutils.Caption                     := '&Barre de boutons';
menuItemBarredoutils.Hint                        := 'Afficher ou masquer la barre d''outils';
menuItemCouleurspanneaux.Caption                 := '&Couleurs panneaux ...';
menuItemCouleurspanneaux.Hint                    := 'Choisir la couleur de fond d''écran';
MenuItemInterfaceanglaise.Caption                := 'Interface en anglais';
MenuItemInterfaceanglaise.Hint                   := 'Afficher l''interface en langue anglaise';
menuItemPleinEcran.Caption                       := '&Plein écran';
menuItemPleinEcran.Hint                          := 'Mettre l''application en plein écran ou restaurer à la taille initiale';
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
sp0titre                                         := 'Présentation du programme';
sp1titre                                         := 'Saisie de l''expression arithmétique';
sp2titre                                         := 'Rapport de compilation';
sp3titre                                         := 'Contenu du fichier exécutable';
sp4titre                                         := 'Contenu du fichier XML';
sp5titre                                         := 'Détail du désassemblage des fichiers générés';
sp6titre                                         := 'Animation du programme';
sp7titre                                         := 'Documentation utilisateur';
sp8titre                                         := 'A propos ...';
// ------------------------------------------------------------
// chaine diverses
// ------------------------------------------------------------
sExecutionDuFichier                              := 'Exécution du fichier : ';
sAttentionSaisie09                               := 'Vous devez saisir des valeurs comprises entre 0 et 9 pour chacune des variables nécessaires à l''exécution de la machine MAP.';
sSaisieDesVariables                              := 'Saisie des variables';
sBienvenue                                       := 'Bienvenue dans l''application ';
sHintParDefaut                                   := 'Appuyez sur F1 pour obtenir de l''aide';
sPret                                            := 'Prêt';
sOccupe                                          := 'Occupé';
sFormatDateHeure                                 := 'dd/mm/yyyy hh:nn';
sChargementDunProgrammeExecutable                := 'Chargement d''un programme exécutable';
sSauvegardeDunProgrammeExecutable                := 'Sauvegarde d''un programme exécutable';
sFichierAideIntrouvable                          := 'Le fichier d''aide est introuvable !';
sOpenDialogueFichiersExecutablesFilter           := 'Fichiers exécutables|*.exec|Tous les fichiers|*.*|Fichiers texte|*.txt|Fichiers XML|*.xml';
// ------------------------------------------------------------
// page presentation
// ------------------------------------------------------------
ButtonAccueilDoc.caption                         := '&Précédent';
ButtonAccueilDoc.Hint                            := 'Page précédente|Affiche la dernière page vue dans l''explorateur';
// ------------------------------------------------------------
// page saisie
// ------------------------------------------------------------
ButtonEffacer.caption                            := '&CE';
ButtonEffacer.Hint                               := 'Effacer|Effacer toutes les zones d''affichage.';
ButtonGenerAutExprArithm.caption                 := '&Générer automatiquement une expression arithmétique';
ButtonGenerAutExprArithm.Hint                    := 'Générer|Genère automatiquement une expression arithmétique';
ButtonRetour.caption                             := '&Retour';
ButtonRetour.Hint                                := 'Retour|Effacer le dernier caractère saisie dans l''écran';
ButtonTradPostFix.caption                        := '&Traduire en postfixé et générer code et exécutable' ;
ButtonTradPostFix.Hint                           := 'Traduction|Traduction de l''expression arithmétique en postfixé ; Géneration de deux fichiers (code et exécutable)';
PanelCopiecalc.Hint                              := 'Zone d''affichage de la traduction de l''expression arithmétique';
PanelSaisieCalc.Hint                             := 'Zone de saisie de l''expression arithmétique';
MemoAide1lines                                   := 'L''utilisateur saisit manuellement et '+
                                                    'directement une expression '+
                                                    'arithmétique dans la première zone, ou en '+
                                                    'utilisant le pavé alphanumérique : en '+
                                                    'cliquant sur une touche le contenu de '+
                                                    ' cette dernière s''affiche '+
                                                    'automatiquement.';
MemoAide2lines                                   := 'Cliquer sur le bouton"Générer..." '+
                                                    'et le programme '+
                                                    'traduira automatiquement '+
                                                    'l''expression arithmétique saisie et ' +
                                                    'l''affichera dans le champ suivant '+
                                                    'en version post-fixée';
// ------------------------------------------------------------
// page rapport
// ------------------------------------------------------------
// néant
// ------------------------------------------------------------
// page executable
// ------------------------------------------------------------
// néant
// ------------------------------------------------------------
// page xml
// ------------------------------------------------------------
ButtonVisuXMLStyle.caption                       := 'Avec Feuille de &styles (XSLT)';
ButtonVisuXMLStyle.Hint := menuItemXMLfeuillestyles.Hint;
// ------------------------------------------------------------
// page desassemblage
// ------------------------------------------------------------
editDesassemblage.text                           := 'Code exécutable';
editExecutable.text                              := 'Code désassemblé';
// ------------------------------------------------------------
// page animation  + erreurs machineMAP
// ------------------------------------------------------------
BitBtJoueExec.Caption                            := '';
BitBtJoueExec.hint                               := 'Joue|Lance l''exécution sur le code du fichier sélectionné';
BitBtnArreteExec.Caption                         := '';
BitBtnArreteExec.hint                            := 'Stop|Arrête l''animation et la replace à son point de départ';
BitBtnOuvreExec.Caption                          := '';
BitBtnOuvreExec.hint                             := 'Ouvrir|Ouvre un fichier exécutable (.exec) pour l''animer';
BitBtnPauseExec.Caption                          := '';
BitBtnPauseExec.hint                             := 'Pause|Arrête momentanément l''animation';
GroupBoxOperande1.Caption                        := ' Opérande 1 ';
GroupBoxOperande1.hint                           := 'Opérande n°1|Registre opérande n°1';
GroupBoxOperande2.Caption                        := ' Opérande 2 ';
GroupBoxOperande2.hint                           := 'Opérande n°2|Registre opérande n°2';
GroupBoxResultat.Caption                         := ' Résultat ';
GroupBoxResultat.hint                            := 'Accumulateur|Accumulateur de la machine';
GroupBoxVariables.Caption                        := ' Variables ';
LabelLent.Caption                                := 'Lent';
LabelNomFichier.Caption                          := 'Sous-titre';
LabelRapide.Caption                              := 'Rapide';
LabelTitreCode.Caption                           := 'CODE ()';
ListBoxCode.hint                                 := 'Instructions|Liste des instructions chargées prêtes pour l''exécution';
ListBoxPileLIFOAnimation.Hint                    := 'Pile|Pile d''exécution de la machine à pile';
StringGridVariablesAnimation.hint                := 'Table des symboles|Table des symboles (entrez des valeurs entre 0 et 9)';
TrackBarAnimation.hint                           := 'Variateur|Variation de la vitesse de l''animation';
// -- Dans machineMAP -----------------------------------------
sDivisionParZero                                 := 'Division par zéro impossible ; rectifiez vos variables.';
sErreurCodeIncorrect                             := 'Erreur uclasseMachineMAP : numéro de code incorrect';
// ------------------------------------------------------------
// page documentation
// ------------------------------------------------------------
//néant
// ------------------------------------------------------------
// page a propos
// ------------------------------------------------------------
sVersionProgramme                                := 'VERSION DU PROGRAMME';
sLabelNumeroConstruction                         := 'Construction';
sLabelDateCompilation                            := 'Date compilation : ';
sLabelAuteurs                                    := 'AUTEURS';
sLabelClassesMetiers                             := 'Classes métiers';
sLabelEquipeDevt                                 := 'Equipe développement agile';
sLabelEquipeConception                           := 'Conception IHM, tests, documentation';
sLabelInstallateur                               := 'INSTALLATEUR';
sLabelInformationsWindows                        := 'INFORMATIONS SYSTEME WINDOWS';
sLabelCliquerici                                 := 'Cliquez ici';
// :FIN
// ============================================================
