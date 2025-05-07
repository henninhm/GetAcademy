updateView()

function header(){
  //let profileButtonHTML = model.app.currentUserId == null ? "" : profileButton()
  return/*HTML*/`
  <div id= "topLeft"> 
    <button onclick="changePage('frontPage')">Forside</button> 
    <button onclick="changePage('daily')">Dagens Quiz</button>
    <button onclick="changePage('weekly')">Ukas Quiz</button>
    <button onclick="changePage('labyrinth')">Labyrint</button>
    <button onclick="changePage('archive')">Arkiv</button>
    <button onclick="changePage('submit')">Egne Quizer</button>
    <button onclick="changePage('user')">Profil</button>
  </div>
  `
  //${profileButtonHTML}  
}

function updateView(){
  const content=chosenView()

  app.innerHTML=/*HTML*/`
  <header>${header()}</header>
  <main>${content}</main>
  `
}

function chosenView(){
  console.log (model.app.currentPage)
  if(model.app.currentPage==model.app.page[0]){
    return frontPageView()
  }else if(model.app.currentPage==model.app.page[1]){
    return dailyQuizView()
  }else if(model.app.currentPage==model.app.page[2]){
    return weeklyQuizView()
  }else if (model.app.currentPage==model.app.page[3]){
    return labyrinthView()
  }else if (model.app.currentPage==model.app.page[4]){
    return archiveView()
  }else if (model.app.currentPage==model.app.page[5]){
    return submitQuizView()
  }else if (model.app.currentPage==model.app.page[6]){
    return profileView()
  //}else if (model.app.currentPage==model.app.page[7]){
  //  return createAccountView()
  }
}

function changePage(newPage){
  model.app.currentPage=newPage;
  updateView()
}