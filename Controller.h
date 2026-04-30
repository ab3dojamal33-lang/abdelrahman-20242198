#ifndef CONTROLLER_H
#define CONTROLLER_H

#include "Post.h"
#include "View.h"

class Controller {
private:
    Post* model;
    View* view;

public:
    Controller(Post* m, View* v) {
        model = m;
        view = v;
    }

    void addComment(int id, string text) {
        Comment c(id, text);
        model->addComment(c);
    }

    void updateView() {
        view->showPost(*model);
    }
};

#endif