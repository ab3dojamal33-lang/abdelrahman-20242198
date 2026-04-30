#ifndef COMMENT_H
#define COMMENT_H

#include <string>
using namespace std;

class Comment {
private:
    int id;
    string content;

public:
    Comment(int id, string content) {
        this->id = id;
        this->content = content;
    }

    int getId() { return id; }
    string getContent() { return content; }
};

#endif