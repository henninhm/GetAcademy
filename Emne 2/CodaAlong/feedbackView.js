function feedbackView() {
    let html = ''
    for(i=0; i<personalTrainerList.length; i++) {
        if(currentUserID == personalTrainerList[i])
            feed = model.data.users.______.feedPT
        }
    for(i=0; i<feed.length; i++) {


        html += /*html*/ `
        <div class='feedbackBox'>
            <div class="profilePic">

            </div>
            <div class="name">

            </div>
            <div class='stars'>
    
            </div>
            <input type="text"id="feedback${i}" placeholder="Skriv en tilbakemelding her...">
        </div>

        `
    }

}