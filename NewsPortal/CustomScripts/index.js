var IndexViewModel = function () {
	var self = this;

	self.pages = [
		{
			name: "News",
			href: "/News.html"
		}
	];
	self.chosenPage = ko.observable(self.pages[0]);
	self.goToPage = function (page) {
        self.chosenPage(page);

        ko.cleanNode($("#pageContainer")[0]);
        $("#pageContainer")[0].innerHTML = "";
        $("#pageContainer").load(page.href);
    };

    self.goToPage(self.pages[0]);
}

$(function () {
    ko.applyBindings(new IndexViewModel(), $("#mainBarViewModel")[0]);
});