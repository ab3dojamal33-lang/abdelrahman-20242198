#ifndef POST_H
#define POST_H

#include <vector>
#include "Comment.h"
using namespace std;

class Post {
private:
    int id;
    string title;
    vector<Comment> comments;

public:
    Post(int id, string title) {
        this->id = id;
        this->title = title;
    }

    int getId() { return id; }
    string getTitle() { return title; }

    void addComment(Comment c) {
        comments.push_back(c);
    }

    vector<Comment> getComments() {
        return comments;
    }
};

#endif