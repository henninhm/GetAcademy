const model = {

    app:{
        currentUserId: null,
        currentPage: 'feedbackPage',
    
        page: [
            'frontPage',
            'uploadPage',
            'feedbackPage',
        ],
    },

    inputs: {
        comments: {
            comment1: '',
            comment2: '',
            comment3: '',
            comment4: '',
        },
    },

    data: {
        users: [
            {userID: 1,
            username: 'PTAdmin',
            exerciseVideos: [], //videoIDs
            exerciseLogs: [],
            admin: true,
            personalTrainer: true,
            feedPT: [468286, 52525252, 14141516, 156567373] //videoIDs
            },
            {userID: 35,
            username: 'Løftekongen86',
            exerciseVideos: [468286, 7328641, 19731797], //videoIDs
            exerciseLogs: [],
            admin: false,
            personalTrainer: false,
            feedPT: []
            },
        ],
        personalTrainerList: [1],

        videos: [
            {videoID: 468286,
            userID: 35,
            responded: false,
            feedback: [],
            ratings: [],
            personalTrainer: 1,
            },
        ],
    },
}