#ifndef VIEW_H
#define VIEW_H

#include <iostream>
#include "Post.h"
using namespace std;

class View {
public:
    void showPost(Post p) {
        cout << "Post ID: " << p.getId() << endl;
        cout << "Title: " << p.getTitle() << endl;

        cout << "Comments:\n";
        for (auto c : p.getComments()) {
            cout << "- " << c.getContent() << endl;
        }
    }
};

#endif