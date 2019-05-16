Rails.application.routes.draw do
  devise_for :users
  # For details on the DSL available within this file, see http://guides.rubyonrails.org/routing.html
  namespace :api, defaults: {format: :json} do
    resources :records, only: [:create, :index, :show, :update, :destroy]
  end
  root "static_pages#root"
end

