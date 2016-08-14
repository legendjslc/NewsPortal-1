function NewsDTO(id, name, content, createTime, editTime) {
	var self = this;

	self.Id = ko.observable(id);
	self.Name = ko.observable(name);
	self.Content = ko.observable(content);
	self.CreateTime = ko.observable(createTime);
	self.EditTime = ko.observable(editTime);
}

function CommentDTO(id, text, commentTime, userName) {
	var self = this;

	self.Id = ko.observable(id);
	self.Text = ko.observable(text);
	self.CommentTime = ko.observable(commentTime);
	self.UserName = ko.observable(userName);
}

var NewsViewModel = function() {
	var self = this;
	var news = [];
	var comments = [];

	self.News = ko.observableArray(news);
	self.Comments = ko.observableArray(comments);
	self.GetNews = function() {
		$.ajax({
			type: "GET",
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            url: "/Home/GetNews"
		}).success(function(data) {
			for(var i = 0; i < data.news.length; i++) {
				news.push(new NewsDTO(data.news[i].Id, data.news[i].Name, data.news[i].Content, data.news[i].CreateTime, data.news[i].EditTime));
			}
			self.News(news);
		}).error(function(){
			console.log("error get news");
		})
	}

	self.GetComments = function(newsId){
		self.Comments.removeAll();
		$.ajax({
			type: "GET",
			dataType: "json",
			contentType: "application/json; charset=utf-8",
			url: "/Home/GetCommentsForNews",
			data: {newsId: newsId}
		}).success(function(data) {
			for(var i = 0; i < data.comments.length; i++) {
				comments.push(new CommentDTO(data.comments[i].Id, data.comments[i].Text, data.comments[i].CommentTime, data.comments[i].UserName));
			}
			self.Comments(comments);
		}).error(function(){
			console.log("error get comments");
		})
	}
	self.GetNews();
}