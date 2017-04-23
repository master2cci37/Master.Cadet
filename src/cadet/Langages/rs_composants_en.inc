(* ==========================================================================
 Nom de classe : rs_composants_en.inc
 Info Version  :  boutons, label, hint, menus anglais
 Copyright : 01/2008 Master 2 CCI /  UFRT / UE1 Professeur :  M.  DI SCALA
 Auteur(s) : Mehdi ALLAS, JF. PACORY, Mahmoud BOUKERROUI
 Etat :   Version initiale
 --------------------------------------------------------------------------
 Révision(s) :
 ========================================================================== *)
// toolButton panneau gauche
// ============================================================
ToolButtonAnimation.Caption                      := '&Animation';                                                                                                                                           
ToolButtonAnimation.Hint                         := 'Page of animation of the principal program|Page of animation, can run a MAP program (.exec)';                                                          
ToolButtonApropos.Caption                        := '&About';                                                                                                                                               
ToolButtonApropos.Hint                           := 'About|Shows information about this application, authors and version';                                                                                  
ToolButtonCodeDASM.Caption                       := '&Desassembling';                                                                                                                                       
ToolButtonCodeDASM.Hint                          := 'Desassembles|Desassembles files generated after running the program';
ToolButtonDocumentation.Caption                  := '&Documentation';                                                                                                                                       
ToolButtonDocumentation.Hint                     := 'User documentation |Show the documentation of the application';                                                                                        
ToolButtonExecutable. Caption                    := '&Executable';                                                                                                                                          
ToolButtonExecutable. Hint                       := 'Executable|Executable file';                                                                                                                           
ToolButtonFichierXML.Caption                     := '&XML file ';                                                                                                                                           
ToolButtonFichierXML.Hint                        := 'XML file|File code under XML format';                                                                                                                  
ToolButtonPresentation.Caption                   := '&Presentation';                                                                                                                                        
ToolButtonPresentation.Hint                      := 'Presentation|Presentation of the program.';                                                                                                            
ToolButtonRapport.Caption                        := '&Report';                                                                                                                                              
ToolButtonRapport.Hint                           := 'Report|File code under text format';                                                                                                                   
ToolButtonSaisie.Caption                         := '&Data entry';                                                                                                                                          
ToolButtonSaisie.Hint                            := 'Computes an expression|Computes an arithmetical expression, translation in "fixed post" and generation of source files and program';                   
// ============================================================
// menus déroulants                                 
// ============================================================
// ------------------------------------------------------------
// File                                             
// ------------------------------------------------------------
MenuItemEnRegistrer.Caption                      := '&Save as';                                                                           
MenuItemEnRegistrer.Hint                         := 'Save an executable file under another name for later use';                           
MenuItemFichier.Caption                          := '&File';                                                                              
MenuItemFichier.Hint                             := '';                                                                                   
MenuItemOuvrir. Caption                          := '&Open';                                                                              
menuitemOuvrir.Hint                              :=  'Open an executable MAP (.exec) file and start the animation';                       
MenuItemQuitter.Caption                          := '&Exit';                                                                              
menuItemQuitter.Hint                             := 'Exit application';                                                                   
// ------------------------------------------------------------
// menu edition                                     
// ------------------------------------------------------------
MenuItemColler.Caption                           := '&Paste';                                      
MenuItemColler.Hint                              := 'Paste an expression from the clipboard';      
MenuItemCopier.Caption                           := '&Copy';                                      
MenuItemCopier.Hint                              := 'Copy an expression to the clipboard';        
MenuItemCouper.Caption                           := '&Cut';                                        
MenuItemCouper.Hint                              := 'Cut an expression to the clipboard';          
MenuItemEdition.Caption                          := '&Edit';                                       
MenuItemEdition.Hint                             := '';                                            
// ------------------------------------------------------------
// Traitements
// ------------------------------------------------------------
menuItemAnimation. Caption                       := '&Animation';                                                                              
menuItemCodeSource.Caption                       := '&Source code';                                                                            
menuItemExecutable.Caption                       := '&Executable';                                                                             
menuItemExportXML.Caption                        := '&XML export';                                                                             
menuItemPresentation.Caption                     := '&Presentation';                                                                           
menuItemRapport.Caption                          := '&Execution Report';                                                                       
menuItemSaisie.Caption                           := '&Save';                                                                                   
menuitemTraitements.Caption                      := '&Processing';                                                                             
menuitemTraitements.Hint                         := '';                                                                                        
menuItemVisualisations.Caption                   := '&Visualizations';                                                                         
menuItemVisualisations.Hint                      := '';                                                                                        
menuItemXMLFeuillestyles.Caption                 := 'XML and style Sheets';                                                                    
menuItemXMLFeuillestyles.Hint                    := 'Explore with style sheets|Shows the current  file with a style sheet (XSLT)';             
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
MenuItemAffichage.Caption                        := '&Display';                                            
MenuItemAffichage.Hint                           := '';                                                    
MenuItemBarredeboutonsGauche.Caption             := '&Left tool bar';                                      
MenuItemBarredeboutonsGauche.Hint                := 'Show the tool bar on the right and vice-versa';       
menuItemBarredesstatuts.Caption                  := '&Status bar';                                         
menuItemBarredesstatuts.Hint                     := 'Show or mask the Status bar';                         
menuItemBarredoutils.Caption                     := '&ToolBar';                                            
menuItemBarredoutils.Hint                        := 'Show or mask the tool bar';                           
menuItemCouleurspanneaux.Caption                 := '&Color panel ...';
menuItemCouleurspanneaux.Hint                    := 'Select panel colors';                                 
MenuItemInterfaceanglaise.Caption                := 'Display Interface in French';
MenuItemInterfaceanglaise.Hint                   := 'Display interface in French';
menuItemPleinEcran.Caption                       := '&Full screen';                                        
menuItemPleinEcran.Hint                          := 'Switch  to Full screen or restore initial size';      
// ------------------------------------------------------------
// menu aide
// ------------------------------------------------------------
MenuItemAide.Caption                             := '&Help';                           
MenuItemAide.Hint                                := '';                                
menuItemAideAppli.Caption                        := '&Help';                           
menuItemAideappli.Hint                           := 'Show Help Application';           
menuItemApropos.Caption                          := '&About';                          
menuItemDocumentation.Caption                    := '&Documentation';                  
MenuItemDocumentation.Hint :=  ToolButtonDocumentation.Hint;  
MenuItemAPropos.Hint := ToolButtonApropos.Hint ;              
// ------------------------------------------------------------                        
// barre des statuts                                                                   
// ------------------------------------------------------------                        
statusbarVue.Hint                                := 'Information on the components of the interface';
StatusBarVue.panels[1].Text := sPret;                                                  
// ============================================================                        
// pages of the tNoteBook                                                              
// ============================================================
// titres des pages                                 
// ------------------------------------------------------------
sp0titre                                         := 'Presentation of the Program';                                    
sp1titre                                         := 'Enter expression';                                               
sp2titre                                         := 'compilation Report';                                             
sp3titre                                         := 'Contents of the executable file ';                               
sp4titre                                         := 'Contents of the XML file ';                                      
sp5titre                                         := 'Detail of the disasembling of the generated files';              
sp6titre                                         := 'Animation Program';                                              
sp7titre                                         := 'User documentation';                                             
sp8titre                                         := 'About';                                                          
// ------------------------------------------------------------
// chaine diverses                                  
// ------------------------------------------------------------
sExecutionDuFichier                              := 'File running : ';                                                                                                                      
sAttentionSaisie09                               := 'You must enter numbers between 0 and 9 for each of the variables that are necessary for running the MAP machine.';                     
sSaisieDesVariables                              := 'Enter variables';                                                                                                                      
sBienvenue                                       := 'Welcome to the application ';                                                                                                          
sHintParDefaut                                   := 'Press on F1 to get help ';                                                                                                             
sPret                                            := 'Ready';                                                                                                                                
sOccupe                                          := 'Busy';                                                                                                                                 
sFormatDateHeure                                 := 'mm/dd/yyyy hh:nn';                                                                                                                     
sChargementDunProgrammeExecutable                := 'Load an executable program';    
sSauvegardeDunProgrammeExecutable                := 'Save an executable program';                                                                                                       
sFichierAideIntrouvable                          := 'Help file not found !';                                                                                                                
sOpenDialogueFichiersExecutablesFilter           := 'Executable files|*.exec|All file s|*.*|Text file s|*.txt|XML file s|*.xml';                                                            
// ------------------------------------------------------------
// page presentation                                
// ------------------------------------------------------------
ButtonAccueilDoc.caption                         := '&Previous';
ButtonAccueilDoc.Hint                            := 'Previous page|Display the last seen page ';
// ------------------------------------------------------------
// page saisie                                      
// ------------------------------------------------------------
ButtonEffacer.caption                            := '&CE';                                                                                                                            
ButtonEffacer.Hint                               := 'Erase|Erase all zones.';                                                                                                         
ButtonGenerAutExprArithm.caption                 := '&Automatically generate arithmetical expression';
ButtonGenerAutExprArithm.Hint                    := 'AutomaticallyGenerate|Generate arithmetical expression ';
ButtonRetour.caption                             := '&Return';
ButtonRetour.Hint                                := 'Return|Erase the last character that was entered on the screen';
ButtonTradPostFix.caption                        := '&Translate into post fixed and generation of code and executable' ;
ButtonTradPostFix.Hint                           := 'Translation|Translation of the arithmetical expression in postfixed ; Generation of two files (code and executable)';
PanelCopiecalc.Hint                              := 'View of the translation of the arithmetical expression';
PanelSaisieCalc.Hint                             := 'Enter zone of the arithmetical expression';
MemoAide1lines                                   := 'The user hits an arithmetical expression '+
                                                    'manually and directly in the first zone, or '+
                                                    'by using the alphanumeric paving: by clicking '+
                                                    'on a key, the contents of this one will '+
                                                    'be shown automatically.';                                                                                                        
MemoAide2lines                                   := 'Click on the Generate button and the program '+                                                                                  
                                                    'will translate the arithmetical expression '+                                                                                    
                                                    'automatically and show it in the following '+                                                                                    
                                                    'field in post fixed version';                                                                                                    
                                                    
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
ButtonVisuXMLStyle.caption                       := 'View with &style sheets (XSLT)';
ButtonVisuXMLStyle.Hint := menuItemXMLFeuillestyles.Hint;
// ------------------------------------------------------------
// page desassemblage
// ------------------------------------------------------------
editDesassemblage.text                           := 'Executable code';  
editExecutable.text                              := 'Desassembled code';
// ------------------------------------------------------------
// page animation  + erreurs machineMAP             
// ------------------------------------------------------------
BitBtJoueExec.Caption                            := '';                                                                                                                                 
BitBtJoueExec.hint                               := 'Play|Start the execution on the code of the selected file ';                                                                       
BitBtnArreteExec.Caption                         := '';                                                                                                                                 
BitBtnArreteExec.hint                            := 'Stop|Stop the animation and put it at its starting point';                                                                         
BitBtnOuvreExec.Caption                          := '';                                                                                                                                 
BitBtnOuvreExec.hint                             := 'Open|Open an executable file (.exec) for the machine';                                                                             
BitBtnPauseExec.Caption                          := '';                                                                                                                                 
BitBtnPauseExec.hint                             := 'Pause|Pause the animation';                                                                                                        
GroupBoxOperande1.Caption                        := ' Operand #1 ';                                                                                                                     
GroupBoxOperande1.hint                           := 'Operand #1|Register Operand #1';                                                                                                   
GroupBoxOperande2.Caption                        := ' Operand #2 ';                                                                                                                     
GroupBoxOperande2.hint                           := 'Operand #2|Register Operand #2';                                                                                                   
GroupBoxResultat.Caption                         := ' Result ';                                                                                                                         
GroupBoxResultat.hint                            := 'Memory|Memory of the machine';                                                                                                     
GroupBoxVariables.Caption                        := ' Variables ';                                                                                                                      
LabelLent.Caption                                := 'Slow';                                                                                                                             
LabelNomFichier.Caption                          := 'Sub title';                                                                                                                        
LabelRapide.Caption                              := 'Fast';                                                                                                                             
LabelTitreCode.Caption                           := 'CODE ()';                                                                                                                          
ListBoxCode.hint                                 := 'Instructions|List of ready charged instructions for the execution';                                                                
ListBoxPileLIFOAnimation.Hint                    := 'Pile|Execution pile of the pile machine';                                                                                          
StringGridVariablesAnimation.hint                := 'Symbols table|Symbols table (enter values between 0 and 9)';                                                                       
TrackBarAnimation.hint                           := 'Speed selection|Speed selection of the animation';                                                                                 
// -- Dans machineMAP -----------------------------------------
sDivisionParZero                                 := 'Division by zero; rectify your variables.';                              
sErreurCodeIncorrect                             := 'Error uclasseMachineMAP : incorrect code number';                        
// ------------------------------------------------------------
// page documentation                               
// ------------------------------------------------------------
//néant                                             
// ------------------------------------------------------------
// page a propos                                    
// ------------------------------------------------------------
sVersionProgramme                                := 'PROGRAM VERSION';                          
sLabelNumeroConstruction                         := 'Construction';                             
sLabelDateCompilation                            := 'Compilation date';                         
sLabelAuteurs                                    := 'AUTHORS';                                  
sLabelClassesMetiers                             := 'Technical classes';                        
sLabelEquipeDevt                                 := 'Agile development team';                   
sLabelEquipeConception                           := 'Conception HMI, tests, documentation';     
sLabelInstallateur                               := 'INSTALLED WITH';                           
sLabelInformationsWindows                        := 'WINDOWS SYSTEM INFORMATIONS ';             
sLabelCliquerici                                 := 'Click here';                               
// :FIN                                             
// ============================================================
                                                    

