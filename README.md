# Projeto Entra21
Exercícios e atividades propostas durante as aulas do Entra21


# Comandos Git

man git-config

git init
git status
git add . or git add <nome do arquivo>
git commit -m "mensagem do commit"
git push -u origin master or git push origin master or git push
git pull origin <branch> => git pull origin master or git pull 

git config --list
git config --list --show-origin
git help config

git config --global init.defaultBranch main

git config --global user.name
git config --global user.email

git config --global user.name "your_name"
git config --global user.email "your_email@example.com"

git config --local user.name
git config --local user.email

git config editor – core.editor
git config --global core.editor "atom --wait
git config --global core.editor "emacs
git config --global core.editor "nano -w
git config --global core.editor "vim
git config --global core.editor "'c:/program files/sublime text 3/sublimetext.exe' -w
git config --global core.editor "mate -w

git config --global merge.tool kdiff3

//como o color.ui, essas configurações também podem ser definidas como false, auto ou always
git config --global color.ui false

git log --decorate

git diff, do git log e do git show




Fontes: 
https://www.atlassian.com/br/git/tutorials/setting-up-a-repository/git-config
https://git-scm.com/book/en/v2/Customizing-Git-Git-Configuration
https://git-scm.com/book/en/v2/Getting-Started-First-Time-Git-Setup
https://git-scm.com/book/en/v2/Getting-Started-Getting-Help